using System.Text.Json;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        List<Parent> parents;
        int id;
        public Form1()
        {
            InitializeComponent();
            parents = new List<Parent>();
            id = 0;
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            FormCreate form = new FormCreate();
            form.Owner = this;
            form.Show();
        }
        private void refresh()
        {
            listView1.Items.Clear();
            foreach (var item in parents)
            {
                listView1.Items.Add(item.ToString());
            }
        }
        public void addParent(string name, int age, string work)
        {
            parents.Add(new Parent()
            {
                id = id,
                name = name,
                age = age,
                work = work
            });
            id++;
            refresh();
        }

        private void buttonAverage_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Agerage value age = {parents.Average(x => x.age)}");

        }

        private void buttonGroup_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            foreach (var item in
                parents.GroupBy(x => x.work).Select(x => new { name = x.Key, count = x.Count() }))
                listView1.Items.Add($"name: {item.name} count: {item.count}");
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private async void buttonSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string path = saveFileDialog1.FileName;
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
                await JsonSerializer.SerializeAsync<List<Parent>>(fs, parents);
            MessageBox.Show("Complete");
        }

        private async void buttonLoad_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string path = openFileDialog1.FileName;
            using(FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                List<Parent>? res = await JsonSerializer.DeserializeAsync<List<Parent>>(fs);
                parents.AddRange(res);
                refresh();
            }
        }
    }
}
