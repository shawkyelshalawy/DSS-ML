using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace piriori_algorithm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            string[] lines = textBoxDataset.Lines;
            List<List<string>> dataset = new List<List<string>>();
            foreach (string line in lines)
            {
                string[] items = line.Split(',');
                dataset.Add(new List<string>(items));
            }

            int minSupport = int.Parse(textBoxMinSupport.Text);
            List<List<string>> frequentItemsets = Apriori(dataset, minSupport);

            string output = "";
            foreach (List<string> itemset in frequentItemsets)
            {
                output += string.Join(", ", itemset) + "\n";
            }
            labelFrequentItemsets.Text = output;
            List<List<string>> Apriori(List<List<string>> dataset, int minSupport)
            {
                // Generate frequent 1-itemsets
                Dictionary<string, int> itemSupports = new Dictionary<string, int>();
                foreach (List<string> transaction in dataset)
                {
                    foreach (string item in transaction)
                    {
                        if (!itemSupports.ContainsKey(item))
                        {
                            itemSupports[item] = 0;
                        }
                        itemSupports[item]++;
                    }
                }

                List<string> frequentItems = new List<string>();
                foreach (KeyValuePair<string, int> pair in itemSupports)
                {
                    if (pair.Value >= minSupport)
                    {
                        frequentItems.Add(pair.Key);
                    }
                }

                // Generate frequent itemsets of size k > 1
                List<List<string>> frequentItemsets = new List<List<string>>();
                frequentItemsets.Add(frequentItems);
                int k = 2;
                while (frequentItemsets[k - 2].Count > 0)
                {
                    List<List<string>> candidateItemsets = GenerateCandidateItemsets(frequentItemsets[k - 2]);
                    itemSupports = CountItemsetSupports(candidateItemsets, dataset);
                    frequentItems = new List<string>();
                    foreach (KeyValuePair<string, int> pair in itemSupports)
                    {
                        if (pair.Value >= minSupport)
                        {
                            frequentItems.Add(pair.Key);
                        }
                    }
                    frequentItemsets.Add(frequentItems);
                    k++;
                }

                // Remove empty itemsets and return frequent itemsets
                frequentItemsets.RemoveAt(frequentItemsets.Count - 1);
                return frequentItemsets;
            }

            List<List<string>> GenerateCandidateItemsets(List<string> frequentItems)
            {
                List<List<string>> candidateItemsets = new List<List<string>>();
                int k = frequentItems[0].Split(',').Length;
                for (int i = 0; i < frequentItems.Count - 1; i++)
                {
                    string[] items1 = frequentItems[i].Split(',');
                    for (int j = i + 1; j < frequentItems.Count; j++)
                    {
                        string[] items2 = frequentItems[j].Split(',');
                        bool canJoin = true;
                        for (int l = 0; l < k - 2; l++)
                        {
                            if (items1[l] != items2[l])
                            {
                                canJoin = false;
                                break;
                            }
                        }
                        if (canJoin)
                        {
                            List<string> candidateItemset = new List<string>(items1);
                            candidateItemset.Add(items2[k - 2]);
                            candidateItemsets.Add(candidateItemset);
                        }
                    }
                }
                return candidateItemsets;
            }

            Dictionary<string, int> CountItemsetSupports(List<List<string>> itemsets, List<List<string>> dataset)
            {
                Dictionary<string, int> itemsetSupports = new Dictionary<string, int>();
                foreach (List<string> itemset in itemsets)
                {
                    itemsetSupports[string.Join(",", itemset)] = 0;
                }
                foreach (List<string> transaction in dataset)
                {
                    foreach (List<string> itemset in itemsets)
                    {
                        bool allItemsInTransaction = true;
                        foreach (string item in itemset)
                        {
                            if (!transaction.Contains(item))
                            {
                                allItemsInTransaction = false;
                                break;
                            }
                        }
                        if (allItemsInTransaction)
                        {
                            itemsetSupports[string.Join(",", itemset)]++;
                        }
                    }
                }
                return itemsetSupports;
            }
        } 
    }
}
