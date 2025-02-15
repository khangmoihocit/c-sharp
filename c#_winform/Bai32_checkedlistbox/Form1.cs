namespace Bai32_checkedlistbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chklistLeft.Items.Add("HaNoi");
            chklistLeft.Items.Add("CaMau");
            chklistLeft.Items.Add("HaTay");
            chklistLeft.Items.Add("BacNinh");

            chklistLeft.Items.AddRange(new string[]
            {
                "TayNinh",
                "HaiPhong",
                "BacGiang"
            });

        }

        private void btnMoveOneFromLeftToRight_Click(object sender, EventArgs e)
        {
            for(int i=0; i<chklistLeft.Items.Count; ++i)
            {
                if(chklistLeft.GetItemChecked(i) == true)
                {
                    chklstRight.Items.Add(chklistLeft.Items[i]);
                    chklistLeft.Items.RemoveAt(i);
                }
            }
        }
    }
}
