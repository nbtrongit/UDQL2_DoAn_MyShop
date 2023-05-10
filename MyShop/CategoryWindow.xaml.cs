using ENTITIES;
using SERVICES;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MyShop
{
    /// <summary>
    /// Interaction logic for CategoryWindow.xaml
    /// </summary>
    public partial class CategoryWindow : Window
    {
        private Category itemUpdate = null;
        private ObservableCollection<Category> category = null;
        private CategoryService categoryService = null;
        public CategoryWindow()
        {
            InitializeComponent();
            this.categoryService = new CategoryService();
            itemUpdate = new Category();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            category = new ObservableCollection<Category>(categoryService.DanhSachCategory());
            CategorysListView.ItemsSource = category;
        }
        private void editMenu_Click(object sender, RoutedEventArgs e)
        {
            if (CategorysListView.SelectedItem != null && textBoxEditCategory.Visibility == Visibility.Hidden)
            {
                itemUpdate.Id = (CategorysListView.SelectedItem as Category).Id;
                itemUpdate.Ten = (CategorysListView.SelectedItem as Category).Ten;
                textBoxEditCategory.Text = itemUpdate.Ten;
                textBoxEditCategory.Visibility = Visibility.Visible;
            }
            else if (textBoxEditCategory.Visibility == Visibility.Visible)
            {
                var item = CategorysListView.SelectedItem as Category;
                if (item.Id == itemUpdate.Id)
                {
                    if (categoryService.SuaCategory(item, textBoxEditCategory.Text.Trim()))
                    {
                        MessageBox.Show("Sửa thành công", "Category", MessageBoxButton.OK);
                        textBoxEditCategory.Visibility = Visibility.Hidden;
                    }
                    else
                    {
                        textBoxEditCategory.Text = item.Ten;
                    }
                }
                else
                {
                    itemUpdate.Id = item.Id;
                    itemUpdate.Ten = item.Ten;
                    textBoxEditCategory.Text = item.Ten;
                }
            }
        }

        private void deleteMenu_Click(object sender, RoutedEventArgs e)
        {
            var temp = CategorysListView.SelectedItem as Category;
            if (categoryService.Xoa1Category(temp))
            {
                category.Remove(temp);
            }    
        }

        private void addCategoryButton_Click(object sender, RoutedEventArgs e)
        {
            if (textBoxNewCategory.Visibility == Visibility.Hidden)
            {
                textBoxNewCategory.Visibility = Visibility.Visible;
            }
            else
            {
                if (categoryService.ThemCategory(textBoxNewCategory.Text) && textBoxNewCategory.Text != "Nhập loại sản phẩm mới")
                {
                    MessageBox.Show("Thêm thành công", "Category", MessageBoxButton.OK);
                    textBoxNewCategory.Visibility = Visibility.Hidden;

                    category = new ObservableCollection<Category>(categoryService.DanhSachCategory());
                    CategorysListView.ItemsSource = category;

                    textBoxNewCategory.Text = "Nhập loại sản phẩm mới";
                    textBoxNewCategory.Foreground = Brushes.Gray;
                }
                else
                {
                    MessageBox.Show("Thêm không thành công", "Category", MessageBoxButton.OK);
                    textBoxNewCategory.Visibility = Visibility.Hidden;
                    textBoxNewCategory.Text = "Nhập loại sản phẩm mới";
                    textBoxNewCategory.Foreground = Brushes.Gray;
                }
            }
        }

        private void deleteCategoryButton_Click(object sender, RoutedEventArgs e)
        {
            var temp = CategorysListView.SelectedItem as Category;
            if (categoryService.Xoa1Category(temp))
            {
                category.Remove(temp);
            }
        }

        private void updateCategoryButton_Click(object sender, RoutedEventArgs e)
        {
            if (CategorysListView.SelectedItem != null && textBoxEditCategory.Visibility == Visibility.Hidden)
            {
                itemUpdate.Id = (CategorysListView.SelectedItem as Category).Id;
                itemUpdate.Ten = (CategorysListView.SelectedItem as Category).Ten;
                textBoxEditCategory.Text = itemUpdate.Ten;
                textBoxEditCategory.Visibility = Visibility.Visible;
            }
            else if (textBoxEditCategory.Visibility == Visibility.Visible)
            {
                var item = CategorysListView.SelectedItem as Category;
                if (item.Id == itemUpdate.Id)
                {
                    if (categoryService.SuaCategory(item, textBoxEditCategory.Text.Trim()))
                    {
                        MessageBox.Show("Sửa thành công", "Category", MessageBoxButton.OK);
                        textBoxEditCategory.Visibility = Visibility.Hidden;
                    }
                    else
                    {
                        textBoxEditCategory.Text = item.Ten;
                    }
                }
                else
                {
                    itemUpdate.Id = item.Id;
                    itemUpdate.Ten = item.Ten;
                    textBoxEditCategory.Text = item.Ten;
                }
            }
        }

        private void textBoxNewCategory_MouseEnter(object sender, MouseEventArgs e)
        {
            textBoxNewCategory.Text = "";
            textBoxNewCategory.Foreground = Brushes.Black;
        }

    }
}
