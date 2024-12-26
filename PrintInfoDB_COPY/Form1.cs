using PrintInfoDB_COPY.Models;

namespace PrintInfoDB_COPY
{
    public partial class FormPartners : Form
    {
        public FormPartners()
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
            }
        }

        private void buttonPartnerAdd_Click(object sender, EventArgs e)
        {
            FormPartnerTypeAdd formPartnerTypeAdd = new();
            DialogResult result  = formPartnerTypeAdd.ShowDialog(this);
            if(result == DialogResult.Cancel) return;

            TypesOfPartner typesOfPartner = new TypesOfPartner();
            {
                TypeOfPartner = formPartnerTypeAdd.textBoxTypeName.Text
            };

            db.PartnersOfType.Add(typesOfPartner);
            db.SaveChanges();

            MessageBox.Show("Новый объект добавлен");

            this.dataGridViewTypes.DataSource = this.db.AnimeTypes.Local
                .OrderBy(o => o.AnimeOfType).ToList();

        }
    }
}
