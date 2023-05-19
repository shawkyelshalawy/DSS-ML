using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace piriori_algorithm
{
    public partial class MainForm : Form
    {
        List<List<string>> itemsMatrix = new List<List<string>>();
        //List<string> allSelectedItems = new List<string>();
        Dictionary<string, int> itemMap = new Dictionary<string, int>();
        public MainForm()
        {
            InitializeComponent();
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Add_item_btn_Click(object sender, EventArgs e)
        {
            String items = Item_txt.Text.ToString();
            Item_List_CB.Items.Add(items);
            itemMap.Add(items, 0);
            Item_txt.Text = "";
            
        }

        private void Bill_List_btn_Click(object sender, EventArgs e)
        {
            List<String> SelectedItems = new List<string>();

            foreach (var item in Item_List_CB.Items)
            {
                if (Item_List_CB.CheckedItems.Contains(item))
                {
                    SelectedItems.Add(item.ToString());
                    if (itemMap.ContainsKey(item.ToString()))
                    {
                        itemMap[item.ToString()]++;
                    }
                }
            }

            string billItems = String.Join(" ", SelectedItems);
            Bill_List.Items.Add(billItems);
            itemsMatrix.Add(SelectedItems);
        }
        private void Save_btn_Click(object sender, EventArgs e)
        {
            int minSupport = int.Parse(Mini_txt.Text.ToString());


            Dictionary<string, int> localitemMap = new Dictionary<string, int>();
            Dictionary<string, int> opartionitemMap = new Dictionary<string, int>();

            localitemMap = itemMap;
            bool notEmpty = true;

            while (notEmpty)
            {
                for (int i = 0; i < localitemMap.Count; i++)
                {
                    if (localitemMap[localitemMap.Keys.ElementAt(i)] < minSupport)
                    {
                        string key = localitemMap.Keys.ElementAt(i);
                        localitemMap.Remove(key);
                    }
                }

                for (int i = 0; i < localitemMap.Count - 1; i++)
                {
                    for (int j = i + 1; j < localitemMap.Count; j++)
                    {
                        string key = localitemMap.Keys.ElementAt(i).ToString() + " " + localitemMap.Keys.ElementAt(j).ToString();
                        string[] keyArr = key.Split(' ');
                        HashSet<string> uniqKey = new HashSet<string>(keyArr);
                        string newkey = string.Join(" ", uniqKey);
                        // opartionitemMap.Clear();
                        if (!opartionitemMap.Keys.Contains(newkey))
                        {
                            opartionitemMap.Add(newkey, 0);
                        }
                    }
                }

                for (int x = 0; x < itemsMatrix.Count; x++)
                {
                    for (int j = 0; j < opartionitemMap.Count; j++)
                    {
                        string key = opartionitemMap.Keys.ElementAt(j).ToString();
                        List<string> keyList = key.Split(' ').ToList();
                        bool allExist = keyList.All(item => itemsMatrix[x].Contains(item));
                        bool allExist2 = itemsMatrix[x].All(item => keyList.Contains(item));

                        if (allExist || allExist2)
                        {
                            opartionitemMap[key]++;
                        }
                    }
                }

                for (int i = 0; i < opartionitemMap.Count; i++)
                {
                    if (opartionitemMap[opartionitemMap.Keys.ElementAt(i)] < minSupport)
                    {
                        string key = opartionitemMap.Keys.ElementAt(i);
                        opartionitemMap.Remove(key);
                    }
                }
                int f = opartionitemMap.Count;

                if (f == 2)
                {
                    notEmpty = false;
                }
                else
                {
                    localitemMap.Clear();
                    localitemMap = new Dictionary<string, int>(opartionitemMap);
                    opartionitemMap.Clear();

                }
            }
            MessageBox.Show(localitemMap.Keys.ElementAt(1).ToString());
            label3.Text = localitemMap.Keys.ElementAt(1).ToString();
        }

    }
}
