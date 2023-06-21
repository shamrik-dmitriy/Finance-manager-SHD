using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp.Test.MenuitemInCombobox
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
            toolStripDropDownButton1.Dock = DockStyle.Fill;
            toolStripDropDownButton1.AutoSize = true;

            // toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
        }


        public void SetDisplayStyle(ToolStripItemDisplayStyle displayStyle)
        {
            toolStripDropDownButton1.DisplayStyle = displayStyle;
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {
            toolStripDropDownButton1.DropDownItems.Clear();
            FillToolStripCategory(toolStripDropDownButton1.DropDownItems, Categories);

            /*
            var tmp = new ToolStripMenuItem("Opa");
            tmp.DropDownItems.Add(new ToolStripMenuItem("asd"));
            toolStripDropDownButton1.DropDownItems.AddRange(new[] { tmp, new ToolStripMenuItem("Opa2") });
            */
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            /* var tmp = new ToolStripMenuItem("Opa");
             tmp.DropDownItems.Add(new ToolStripMenuItem("asd"));
             toolStripDropDownButton1.DropDownItems.AddRange(new[] { tmp, new ToolStripMenuItem("Opa2") });
 */
            FillToolStripCategory(toolStripDropDownButton1.DropDownItems, Categories);
        }

        private List<Category> Categories = new List<Category>()
        {
            new Category()
            {
                Name = "First",
                Categories =
                    new List<Category>()
                    {
                        new Category()
                        {
                            Name = "1",
                            Categories = new List<Category>()
                            {
                                new Category()
                                {
                                    Name = "2", Categories = new List<Category>()
                                    {
                                        new Category() { Name = "3" },
                                        new Category() { Name = "4" },
                                        new Category() { Name = "5" },
                                        new Category()
                                        {
                                            Name = "6", Categories = new List<Category>()
                                            {
                                                new Category() { Name = "8" },
                                                new Category() { Name = "9" },
                                            }
                                        },
                                        new Category() { Name = "7" }
                                    }
                                }
                            }
                        },
                        new Category()
                        {
                            Name = "1",
                            Categories = new List<Category>() { new Category() { Name = "2" } }
                        },
                        new Category()
                        {
                            Name = "Sub2",
                            Categories = new List<Category>() { new Category() { Name = "SubSub2" } }
                        }
                    }
            },
            new Category()
            {
                Name = "Second",
                Categories = new List<Category>()
                {
                    new Category()
                    {
                        Name = "SubSecond",
                        Categories = new List<Category>() { new Category() { Name = "SubSubSecond" } }
                    }
                }
            }
        };

        private void FillToolStripCategory(ToolStripItemCollection dropdownItems, List<Category> categories)
        {
            // Перебор родительских категорий
            foreach (var category in categories)
            {
                var cat = new ToolStripMenuItem(category.Name)
                {
                    //Поместить в тег какую-либо служебную информацию 
                    //для идентификации элемента меню
                    //(для поиска в БД)
                    Tag = ""
                };
                
                cat.Click += CategoryClick;
                
                // Добавление родительской категории в список
                dropdownItems.Add(cat);

                // Заполним список дочерних категорий
                // Если у категории есть хотя бы одна подкатегория
                if (category.Categories != null && category.Categories.Any())
                {
                    //TODO: Понять к какой подкатегории добавлять (Условно надо 
                    //TODO: передать дропдауны ранее добавленной)
                    FillToolStripCategory(cat.DropDownItems, category.Categories);
                }
            }
        }

        private void CategoryClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private ToolStripItemCollection FillCategory(ToolStripItemCollection parent, List<Category> categories)
        {
            if (categories == null)
                return null;

            // Перебор дочерних категорий
            foreach (var cat in categories)
            {
                if (cat.Categories != null && cat.Categories.Any())
                    FillCategory(parent, cat.Categories);

                var lvl0Cat = new ToolStripMenuItem(cat.Name);
                lvl0Cat.DropDownItems.Add(cat.Name);
                parent.Add(lvl0Cat);

                return parent;
            }

            return parent;
        }
    }
/*
 * Берем родителя
 * смотрим есть ли у родителя дочерние
 * если есть - опускаемся вниз.
 * если нет - добавляем.
 */


    public class Category
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Category> Categories { get; set; }
    }
}