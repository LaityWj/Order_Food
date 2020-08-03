using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using Newtonsoft.Json;
using Order_Food_View.HelperClass;
using Order_Food_View.Page.TS_eat;
using Order_Food_View.ViewModel;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Order_Food_View.UserControl.TSEatControl
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class TSBuyCar : Smobiler.Core.Controls.MobileUserControl
    {
        public delegate void CarListLoad();
        HttpClientHelper http = new HttpClientHelper("http://192.168.43.51:8081");
        public TSBuyCar() : base()
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent();
        }
       
        public  CarListLoad CarLoad;
        public void GetCarRescution()
        {
            string getCarList = http.Get("/Menu/GetCars");
            Data data = JsonConvert.DeserializeObject<Data>(getCarList);
            string json = JsonConvert.SerializeObject(data.Result);
            List<ShowCarModel> list = JsonConvert.DeserializeObject<List<ShowCarModel>>(json);
            if (list != null)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    TSBuyCarRes sg = new TSBuyCarRes(list[i]);
                    panel2.Controls.Add(sg);
                    sg.Location = new System.Drawing.Point(0, i * 50);
                }
            }
        }
        private void imageButton1_Press(object sender, EventArgs e)
        {
            //调用清空接口的api
            string state = http.del("/Menu/DeleteCars");
            if (state == "1")
            {
                GetCarRescution();
                this.Close();
            }
        }
        private void TSBuyCar_Load(object sender, EventArgs e)
        {
            GetCarRescution();
            GetCarList();
        }
        public void GetCarList()
        {
            int h = 1;
            string getCarList = http.Get("/Menu/GetCars");
            Data data = JsonConvert.DeserializeObject<Data>(getCarList);
            string json = JsonConvert.SerializeObject(data.Result);
            List<ShowCarModel> list = JsonConvert.DeserializeObject<List<ShowCarModel>>(json);
            DataTable table = GetListToDataTable.ListToDataTable(list);
            if (table.Rows.Count>0)
            { 
            for (int i = 0; i < table.Rows.Count; i++)
            {
                int n = i % 1;
                if (n == 0 && i != 0) //这个条件语句的意思是：如果控件的数量正好是1的倍数的话那么tmp+1  这个是用于控制y轴的
                {
                    h++;
                }
                int x = n * 0, y = 49 * h;//这里定义的x和y便于控制控件在界面上的位置 
                int x1 = n * 10, y1 = 49 * h;
                int x2 = n * 128, y2 = 49 * h;
                int x3 = n * 278, y3 = 57 * h;
                int x4 = n * 235, y4 = 57 * h;
                int x5 = n * 255, y5 = 57 * h;

                Label label = new Label();
                Label Menuname = new Label();
                Label price = new Label();
                Button btnplus = new Button();
                Button btndes = new Button();
                TextBox numberSum = new TextBox();

                label.Dock = System.Windows.Forms.DockStyle.Top;
                label.BorderRadius = 0;
                label.Location = new System.Drawing.Point(x + 0, y);
                label.Size = new System.Drawing.Size(300, 35);
                label.BackColor = System.Drawing.Color.WhiteSmoke;
                panel2.Controls.Add(label);

                Menuname.Dock = System.Windows.Forms.DockStyle.Top;
                Menuname.BorderRadius = 0;
                Menuname.Location = new System.Drawing.Point(x1 + 0, y1);
                Menuname.Size = new System.Drawing.Size(100, 35);
                Menuname.Name = table.Rows[i]["Menu_Id"].ToString();
                Menuname.Text = table.Rows[i]["Menu_Name"].ToString();
                Menuname.DataMember = table.Rows[i]["Menu_Id"].ToString();
                Menuname.DisplayMember = table.Rows[i]["Menu_Name"].ToString();
                Menuname.BackColor = System.Drawing.Color.WhiteSmoke;
                Menuname.ForeColor = System.Drawing.Color.Black;
                panel2.Controls.Add(Menuname);

                price.Dock = System.Windows.Forms.DockStyle.Top;
                price.BorderRadius = 0;
                price.Location = new System.Drawing.Point(x2 + 0, y2);
                price.Size = new System.Drawing.Size(56, 35);
                price.Name = table.Rows[i]["Food_Id"].ToString();
                price.Text = table.Rows[i]["Food_Name"].ToString();
                price.DataMember = table.Rows[i]["Food_Id"].ToString();
                price.DisplayMember = table.Rows[i]["Food_Name"].ToString();
                price.BackColor = System.Drawing.Color.WhiteSmoke;
                price.ForeColor = System.Drawing.Color.Red;
                panel2.Controls.Add(price);

                btnplus.BorderRadius = 0;
                btnplus.Location = new System.Drawing.Point(x3 + 0, y3);
                btnplus.Dock = System.Windows.Forms.DockStyle.Top;
                btnplus.Size = new System.Drawing.Size(16, 18);
                btnplus.Name = table.Rows[i]["Food_Id"].ToString();
                btnplus.Text = table.Rows[i]["Menu_Price"].ToString();
                btnplus.DataMember = table.Rows[i]["Food_Id"].ToString();
                btnplus.DisplayMember = table.Rows[i]["Menu_Price"].ToString();
                btnplus.BackColor = System.Drawing.Color.WhiteSmoke;
                btnplus.ForeColor = System.Drawing.Color.Black;
                btndes.Press += new EventHandler(Addbtn_Click);//button的单击事件  
                panel2.Controls.Add(btnplus);


                btndes.BorderRadius = 0;
                btndes.Location = new System.Drawing.Point(x4 + 0, y4);
                btndes.Dock = System.Windows.Forms.DockStyle.Top;
                btndes.Size = new System.Drawing.Size(16, 18);
                btndes.Text = "+";
                btndes.BackColor = System.Drawing.Color.WhiteSmoke;
                btndes.ForeColor = System.Drawing.Color.Black;
                btndes.Press += new EventHandler(Delbtn_Click);//button的单击事件  
                panel2.Controls.Add(btndes);


                numberSum.BorderRadius = 0;
                numberSum.Location = new System.Drawing.Point(x5 + 0, y5);
                numberSum.Dock = System.Windows.Forms.DockStyle.Top;
                numberSum.Size = new System.Drawing.Size(20, 18);
                numberSum.Name = "1";
                numberSum.Text = "1";
                numberSum.BackColor = System.Drawing.Color.WhiteSmoke;
                numberSum.ForeColor = System.Drawing.Color.Black;
                panel2.Controls.Add(numberSum);

            }
            }
            this.Close();
           
            
        }

        private void button2_Press(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Press(object sender, EventArgs e)
        {

        }
        //add
        private void Addbtn_Click(object sender, EventArgs e)
        {
            Button btnplus = sender as Button;
            TextBox mName = (TextBox)panel2.Controls.Find("numberSum");
            int menuId = int.Parse(btnplus.Name);
            int number = int.Parse(mName.Name);
            UserBuyIdModel userBuyId = new UserBuyIdModel
            {
                menuId = menuId,
                count = number
            };
            http.Post("/Menu/AddCar", JsonConvert.SerializeObject(userBuyId)); 
            TS_EatFormList form = new TS_EatFormList(); 
          //  form.GetCar(); 
        }
        //jiang
        private void Delbtn_Click(object sender, EventArgs e)
        {

        }
    }
}