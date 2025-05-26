using System.Text.Json;
using System.Threading.Tasks;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        List<Patient> patients;
        int id;
        public Form1()
        {
            InitializeComponent();
            patients = new List<Patient>();
            id = 0;
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            CreateForm form = new CreateForm();
            form.Owner = this;
            form.Show();
        }
        private void refresh()
        {
            listView1.Items.Clear();
            foreach (var item in patients)
                listView1.Items.Add(item.ToString());
        }
        public void addPatient(string name, int age)
        {
            patients.Add(new Patient()
            {
                id = id,
                name = name,
                age = age
            });
            id++;
            refresh();
        }

        private void buttonAverage_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            double averageAge = patients.Average(x => x.age);
            foreach (var item in patients.Where(x => x.age >= averageAge))
                listView1.Items.Add(item.ToString());
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void buttonGroup_Click(object sender, EventArgs e)
        {
            var mostcoutn = patients
                .GroupBy(x => x.name).Select(x => new { name = x.Key, count = x.Count() })
                .MaxBy(x => x.count);
            MessageBox.Show($"Most count name: {mostcoutn.name} - {mostcoutn.count}");
        }

        private async void buttonSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string path = saveFileDialog1.FileName;
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
                await JsonSerializer.SerializeAsync<List<Patient>>(fs, patients);
            MessageBox.Show("Complete");
        }

        private async void buttonLoad_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string path = openFileDialog1.FileName;
            using(FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                List<Patient>? res = await JsonSerializer.DeserializeAsync<List<Patient>>(fs);
                patients.AddRange(res);
                refresh();
            }
        }
    }
}
