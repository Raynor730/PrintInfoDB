namespace PrintInfoDB_COPY
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            using (PartnersContext db = new PartnersContext())
            {
                var entityPartners = db.Partners.ToList();
                var entityPartnersProducts = db.PartnersProducts.ToList();
                var entityProducts = db.Products.ToList();

                foreach (Partner u in entityPartners)
                {
                    labelOut.Text += $"{u.Id} - {u.IdTypeOfPartner} - {u.NamePartner} - {u.LegalAddres} - {u.Inn} - {u.DirectorFullName} - {u.Phone} - {u.Email} - {u.Rating} \n";
                }
                /*המבאגטעü םא פמנללף כויבכû ט גûגמהטעü ג כויבכû*/

            }
        }
    }
}
