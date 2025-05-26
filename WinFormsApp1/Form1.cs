using System.Text.Json;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        List<Entity> entities;
        int id = 0;
        public Form1()
        {
            InitializeComponent();
            entities = new List<Entity>();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Create create = new Create();
            create.Owner = this;
            create.Show();
        }
        public void addEntity(string name, int age, string country, string phone)
        {
            Entity entity = new Entity()
            {
                id = id,
                name = name,
                age = age,
                country = country,
                phone = phone
            };
            id++;
            entities.Add(entity);
            updateList();
        }
        private void updateList()
        {
            listView.Items.Clear();
            foreach (var item in entities)
            {
                listView.Items.Add(item.ToString());
            }
        }

        private void buttonSortAge_Click(object sender, EventArgs e)
        {
            listView.Items.Clear();
            foreach (var item in entities.OrderBy(x => x.age))
                listView.Items.Add(item.ToString());
        }
        private void refreshList()
        {
            listView.Items.Clear();
            foreach (var item in entities)
            {
                listView.Items.Add(item.ToString());
            }
        }
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            refreshList();
        }

        private void buttonGroupCountry_Click(object sender, EventArgs e)
        {
            listView.Items.Clear();
            foreach (var item in
                entities.GroupBy(x => x.country).Select(x => new { name = x.Key, count = x.Count() }))
            {
                listView.Items.Add($"{item.name} - {item.count}");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            entities.Remove(entities.First(x => x.id == int.Parse(listView.SelectedItems[0].Text.Split(' ')[1])));
            refreshList();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Entity entity = entities.First(x => x.id == int.Parse(listView.SelectedItems[0].Text.Split(' ')[1]));
            Create create = new Create(entity);
            create.Owner = this;
            create.Show();

        }
        public void updateElement(Entity entity)
        {
            entities.Remove(entities.First(x => x.id == entity.id));
            entities.Add(entity);
            refreshList();
        }

        private async void buttonSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string path = saveFileDialog1.FileName;

            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                await JsonSerializer.SerializeAsync<List<Entity>>(fs, entities);
            }
            MessageBox.Show("Сохранено");

        }

        private async void buttonLoad_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string path = openFileDialog1.FileName;
            using(FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                List<Entity>? res = await JsonSerializer.DeserializeAsync<List<Entity>>(fs);
                entities.AddRange(res);
                refreshList();
            }
        }
    }
}
