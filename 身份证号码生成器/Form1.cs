using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;

namespace 身份证号码生成器
{

    public partial class Form1 : Form
    {

        static string ENTER_MSG = "输入18位身份证号码";
        int gender = 1;//1-male,0-female
        string areaCode = "110000";
        AreaCodeXml codeXml = new AreaCodeXml();
        IDNoGen gen = new IDNoGen();




        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            proBox.Items.AddRange(codeXml.getProList());
            this.proBox.SelectedIndex = 0;
            this.birthdayPicker.Value = gen.getRandomDate(DateTime.Now.AddYears(-80), DateTime.Now.AddYears(-25));
        }

        private void pro_TextChanged(object sender, EventArgs e)
        {
            cityBox.Items.Clear();
            cityBox.Items.AddRange(codeXml.getCityList(proBox.Text));
            cityBox.SelectedIndex = 0;
        }

        private void city_TextChanged(object sender, EventArgs e)
        {
            districtBox.Items.Clear();
            districtBox.Items.AddRange(codeXml.getDistrictList(proBox.Text, cityBox.Text));
            districtBox.SelectedIndex = 0;
        }

        private void district_TextChanged(object sender, EventArgs e)
        {
            this.areaCode = codeXml.getRegionCode(proBox.Text, cityBox.Text, districtBox.Text);
        }

        private void generate_Click(object sender, EventArgs e)
        {
            listResult.Clear();
            this.gender = male.Checked ? 1 : 0;
            for (int i = 0; i < 50; i++)
                listResult.AppendText(gen.genIDNo(areaCode, birthdayPicker.Value, gender)
                    + "\n");
        }

        private void IDNo_Click(object sender, EventArgs e)
        {
            if (ENTER_MSG.Equals(IDNo.Text))
            {
                IDNo.ForeColor = Color.Black;
                IDNo.Clear();
            }
        }

        private void check_Click(object sender, EventArgs e)
        {
            string idNo = IDNo.Text.Trim();
            if (ENTER_MSG.Equals(idNo) || idNo.Length == 0)
            {
                checkResult.Text = ENTER_MSG + "！";
                return;
            }
            string msg;
            gen.checkIDNo(idNo, out msg);
            checkResult.Text = msg;
        }

        private void reset_Click(object sender, EventArgs e)
        {
            IDNo.ForeColor = Color.Gray;
            IDNo.Text = ENTER_MSG;
            checkResult.Clear();
        }

        private void birthdayPicker_ValueChanged(object sender, EventArgs e)
        {
            ageBox.Value = DateTime.Now.Year - this.birthdayPicker.Value.Year;
        }

        // private void ageBox_TextChanged(object sender, EventArgs e)
        //{
        //try
        //{
        //    int age = int.Parse(ageBox.Text);
        //    if (age < 0)
        //        ageBox.Clear();
        //    else
        //this.birthdayPicker.Value = DateTime.Now.AddYears(-age);

        //}catch(Exception)
        //{
        //    ageBox.Clear();
        //}                
        // }

        private void ageBox_ValueChanged(object sender, EventArgs e)
        {
            int age = (int)ageBox.Value;
            this.birthdayPicker.Value = DateTime.Now.AddYears(-age);
        }

    }

    //身份证号生成
    public class IDNoGen
    {
        Random rand = new Random();
        AreaCodeXml codeXml = new AreaCodeXml();

        //生成18位身份证号
        public string genIDNo(string areaCode, DateTime birthday, int gender)
        {
            int idLast3 = 0;
            do
            {
                idLast3 = rand.Next(1, 999);
            } while ((idLast3 % 2) != gender);
            string id17 = areaCode + birthday.ToString("yyyyMMdd") + idLast3.ToString("000");
            return id17 + this.calCheckCode(id17);
        }

        //15位身份证号转18位
        public string generate15To18(string id)
        {
            if (id.Length != 15)
                return id;
            id = id.Insert(6, "19");
            return id + this.calCheckCode(id.Substring(0, 17));
        }

        public DateTime getRandomDate(DateTime min, DateTime max)
        {
            TimeSpan ts = new TimeSpan(max.Ticks - min.Ticks);
            int dayRand = rand.Next(1, ts.Days);
            return min.AddDays(dayRand);
        }

        //检查身份证号是否正确
        public void checkIDNo(string idNo, out string msg)
        {
            idNo = this.generate15To18(idNo);
            try
            {
                string regionName = codeXml.getRegionName(idNo.Substring(0, 6));
                msg = null == regionName ? "地址码不能识别" : "地址：" + regionName;

                DateTime dt = new DateTime();
                bool b = DateTime.TryParse(idNo.Substring(6, 8).Insert(4, "-").Insert(7, "-"), out dt);
                int age = DateTime.Now.Year - dt.Year;
                msg += b ? "；年龄：" + age.ToString() : "；出生日期码不是日期格式";

                string valCode = this.calCheckCode(idNo.Substring(0, 17));
                msg += idNo.EndsWith(valCode) ? "" : "；第18位校验码为：" + valCode;
            }
            catch (Exception)
            {
                msg = "不是身份证号码！";
            }

        }

        //计算校验码
        public string calCheckCode(string id17)
        {
            int[] weight = { 7, 9, 10, 5, 8, 4, 2, 1, 6, 3, 7, 9, 10, 5, 8, 4, 2 };
            string[] validate = { "1", "0", "X", "9", "8", "7", "6", "5", "4", "3", "2" };
            int sum = 0;
            char[] id = id17.ToCharArray();
            for (int i = 0; i < 17; i++)
                sum += int.Parse(id[i].ToString()) * weight[i];
            int mod = sum % 11;
            return validate[mod];
        }

    }

    //读取area_code.xml，获取省市区、地址码
    public class AreaCodeXml
    {
        XmlDocument doc = new XmlDocument();
        static string SPERCIAL_REGION = "台湾省香港特别行政区澳门特别行政区";
        static string PRO_XPATH = "/areas/regionEntitys/region";
        static string CITY_XPATH = PRO_XPATH + "[.='{0}']/../regionEntitys/region";
        static string DISTRICT_XPATH = CITY_XPATH + "[.='{1}']/../regionEntitys/region";
        static string CODE_XPATH = DISTRICT_XPATH + "[.='{2}']/preceding-sibling::code";

        public AreaCodeXml()
        {
            doc.LoadXml(Properties.Resources.area_code);
        }

        //获取地址码
        public string getRegionCode(string pro)
        {
            string s = string.Format(PRO_XPATH + "[.='{0}']/preceding-sibling::code", pro);
            return doc.SelectSingleNode(s).InnerText;
        }

        public string getRegionCode(string pro, string city)
        {
            if (SPERCIAL_REGION.Contains(pro))
                return this.getRegionCode(pro);
            string s = string.Format(CITY_XPATH + "[.='{1}']/preceding-sibling::code", pro, city);
            return doc.SelectSingleNode(s).InnerText;
        }

        public string getRegionCode(string pro, string city, string district)
        {
            if (SPERCIAL_REGION.Contains(pro))
                return this.getRegionCode(pro);
            string s = string.Format(CODE_XPATH, pro, city, district);
            return doc.SelectSingleNode(s).InnerText;
        }

        //获取地址
        public string getRegionName(string code)
        {
            XmlNode d = doc.SelectSingleNode(string.Format("//code[.='{0}']/following-sibling::region", code));
            XmlNode c = doc.SelectSingleNode(string.Format("//code[.='{0}']/../../region", code));
            XmlNode p = doc.SelectSingleNode(string.Format("//code[.='{0}']/../../../region", code));
            return null == d ? null : p.InnerText + c.InnerText + d.InnerText;
        }

        //获取省直辖市特区列表
        public string[] getProList()
        {
            return this.getRegionNodesList(PRO_XPATH).ToArray();
        }

        //获取市列表
        public string[] getCityList(string pro)
        {
            List<string> citys = new List<string>();
            if (SPERCIAL_REGION.Contains(pro))
                citys.Add(pro);
            else
                citys = this.getRegionNodesList(string.Format(CITY_XPATH, pro));
            return citys.ToArray();
        }

        //获取区列表
        public string[] getDistrictList(string pro, string city)
        {
            List<string> districts = new List<string>();
            if (SPERCIAL_REGION.Contains(pro))
                districts.Add(pro);
            else
                districts = this.getRegionNodesList(string.Format(DISTRICT_XPATH, pro, city));
            return districts.ToArray();
        }

        //获取xml所有xpath节点的innertext
        private List<string> getRegionNodesList(string xpath)
        {
            XmlNodeList nodes = doc.SelectNodes(xpath);
            List<string> list = new List<string>();
            foreach (XmlNode n in nodes)
            {
                list.Add(n.InnerText);
            }
            return list;
        }

    }
}
