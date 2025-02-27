using AntdUI;
using CryptoTool.Algorithms;
using CryptoTool.Models;
using CryptoTool.render;
using CryptoTool.Utils;
using CryptoTool.View;
using CryptoTool.View.SubView;
using Microsoft.Win32;
using System.Windows.Forms;

namespace CryptoTool
{
    public partial class MainForm : AntdUI.Window
    {
        //private RSAForm rsaForm;
        //private AESForm aesForm;
        //private Base64Form base64Form;
        private UserControl currControl;
        private bool isUpdatingTabs = false;//用于阻止Tabs更新
        private bool isLight = true;
        // 定义一个语言切换事件
        public event EventHandler LanguageChanged;
        public MainForm()
        {
            InitializeComponent();
            LoadMenu();
            InitData();
            BindEventHandler();
            //rsaForm = new RSAForm();
            //aesForm = new AESForm();
            //base64Form = new Base64Form();

            //ShowForm(rsaForm);
            //menuRenderer = new CustomMenuRenderer();
            //mainMenuStrip.Renderer = menuRenderer;

            //rsaToolStripMenuItem.Click += MenuItem_Click;
            //aesToolStripMenuItem.Click += MenuItem_Click;
            //base64ToolStripMenuItem.Click += MenuItem_Click;

        }

        private void InitData()
        {
            dropdown_translate.SelectedValue = dropdown_translate.Items[0];
            //根据系统亮暗初始化一次
            isLight = ThemeHelper.IsLightMode();
            button_color.Toggle = !isLight;
            ThemeHelper.SetColorMode(this, isLight);
            //初始化消息弹出位置
            Config.ShowInWindow = true;
            menu.Collapsed = false;
            menu.Width = (int)(150 * Config.Dpi);

            //UserControl control = new RSAForm();
            //AutoDpi(control);
            //panel_content.Controls.Add(control);

            ////global
            //tabs.Pages[0].Text = AntdUI.Localization.Get("home", "主页");
        }

        private void BindEventHandler()
        {
            buttonSZ.Click += ButtonSZ_Click;
            button_color.Click += Button_color_Click;
            input_search.TextChanged += Input_search_textchanged;
            menu.SelectChanged += Menu_SelectChanged;
            button_collapse.Click += Button_collapse_Click;
            tabs.Click += Tabs_Click;
            tabs.SelectedIndexChanged += Tabs_SelectedIndexChanged;
            //dropdown_translate.SelectedValueChanged += Dropdown_translate_SelectedValueChanged;
            ////监听系统深浅色变化
            SystemEvents.UserPreferenceChanged += SystemEvents_UserPreferenceChanged;
        }

        private void ButtonSZ_Click(object sender, EventArgs e)
        {
            using (var form = new SystemSet(this))
            {
                string title = AntdUI.Localization.Get("systemset", "系统设置");
                AntdUI.Modal.open(new AntdUI.Modal.Config(this, title, form, TType.Info)
                {
                    CloseIcon = true,
                    BtnHeight = 0,
                });
            }
        }

        private void Tabs_Click(object sender, EventArgs e)
        {
            // 强制转换 EventArgs 为 MouseEventArgs
            MouseEventArgs mouseEventArgs = e as MouseEventArgs;

            if (mouseEventArgs != null)
            {
                if (mouseEventArgs.Button == MouseButtons.Right)
                {
                    string closeall = AntdUI.Localization.Get("closeall", "关闭所有选项卡");
                    var menulist = new AntdUI.IContextMenuStripItem[]
                    {
                        new AntdUI.ContextMenuStripItem(closeall)
                        {
                            IconSvg= "CloseOutlined"
                        }
                    };

                    AntdUI.ContextMenuStrip.open(tabs, item =>
                    {
                        if (item.Text == closeall)
                        {
                            tabs.SelectedIndex = 0;
                            // 只清除从第二个页面开始的控件
                            for (int i = 1; i < tabs.Pages.Count; i++)
                            {
                                tabs.Pages[i].Controls.Clear();
                            }

                            // 移除除了第一个页面之外的所有页面
                            if (tabs.Pages.Count > 1)
                            {
                                tabs.Pages.RemoveRange(1, tabs.Pages.Count - 1);  // 从索引1开始，移除后面的所有页面
                            }
                            menu.Select(null);
                            menu.Refresh();
                        }

                    }, menulist);
                }
            }
        }

        private void Tabs_SelectedIndexChanged(object sender, IntEventArgs e)
        {
            SelectMenu();
        }

        private void Input_search_textchanged(object sender, EventArgs e)
        {
            titlebar.Loading = true;
            var text = input_search.Text.ToLower(); // 将输入文本转换为小写，确保搜索不区分大小写
            LoadMenu(text); // 传递搜索文本
            titlebar.Loading = false;
        }

        private void SystemEvents_UserPreferenceChanged(object sender, UserPreferenceChangedEventArgs e)
        {
            if (e.Category == UserPreferenceCategory.General)
            {
                isLight = ThemeHelper.IsLightMode();
                button_color.Toggle = !isLight;
                ThemeHelper.SetColorMode(this, isLight);
            }
        }

        private void Button_color_Click(object sender, EventArgs e)
        {
            isLight = !isLight;
            //这里使用了Toggle属性切换图标
            button_color.Toggle = !isLight;
            ThemeHelper.SetColorMode(this, isLight);
        }

        private void Button_collapse_Click(object sender, EventArgs e)
        {
            if (menu.Collapsed)
            {
                menu.Width = (int)(250 * Config.Dpi);
            }
            else
            {
                menu.Width = (int)(70 * Config.Dpi);
            }
            button_collapse.Toggle = !button_collapse.Toggle;
            menu.Collapsed = !menu.Collapsed;
        }

        private void SelectMenu()
        {
            if (isUpdatingTabs) return;
            var text = tabs.SelectedTab?.Text; // 使用安全导航操作符，防止 SelectedTab 为 null
            if (string.IsNullOrEmpty(text)) // 检查 text 是否为 null 或空
            {
                return; // 如果 text 为空，直接退出方法
            }
            //首页
            if (text == AntdUI.Localization.Get("home", "主页"))
            {
                return;
            }
            var rootIndex = 0;
            var subIndex = 0;
            var menuItemsCopy = menu.Items.ToList(); // 创建副本
            for (int i = 0; i < menuItemsCopy.Count; i++)
            {
                for (int j = 0; j < menuItemsCopy[i].Sub.Count; j++)
                {
                    if (menuItemsCopy[i].Sub[j].Tag.ToString() == text)
                    {
                        rootIndex = i;
                        subIndex = j;
                        break;
                    }
                }
            }
            menu.SelectIndex(rootIndex, subIndex, true);
        }

        private void LoadMenu(string filter = "")
        {
            menu.Items.Clear();

            string lang = AntdUI.Localization.CurrentLanguage;
            var menuItems = DataUtil.MenuItems_zhcn;
            var menuIcons = DataUtil.MenuIcons_zhcn;
            if (lang.StartsWith("en"))
            {
                menuItems = DataUtil.MenuItems_enus;
                menuIcons = DataUtil.MenuIcons_enus;
            }

            foreach (var rootItem in menuItems)
            {
                var rootKey = rootItem.Key.ToLower();
                var rootMenu = new AntdUI.MenuItem
                {
                    Text = rootItem.Key,
                    IconSvg = menuIcons.TryGetValue(rootItem.Key, out var icon) ? icon : "UnorderedListOutlined",
                };
                bool rootVisible = false; // 用于标记是否显示根节点

                foreach (var item in rootItem.Value)
                {
                    var childText = item.Text.ToLower();

                    // 如果子节点包含搜索文本
                    if (childText.Contains(filter))
                    {
                        var menuItem = new AntdUI.MenuItem
                        {
                            Text = item.Text,
                            IconSvg = item.IconSvg,
                            Tag = item.Tag,
                        };
                        rootMenu.Sub.Add(menuItem);
                        rootVisible = true; // 如果有子节点包含，则显示根节点
                    }
                }

                // 如果根节点包含搜索文本，或有可见的子节点，则显示根节点
                if (rootKey.Contains(filter) || rootVisible)
                {
                    menu.Items.Add(rootMenu);
                }
            }
        }

        private void Menu_SelectChanged(object sender, MenuSelectEventArgs e)
        {
            string name = (string)e.Value.Tag;

            // 如果上一个组件是 FloatButtonDemo，清理其浮动按钮窗体
            //if (currControl is FloatButtonDemo floatButtonDemo)
            //{
            //    floatButtonDemo.CloseFloatButtonForm();
            //}

            // 检查是否已存在同名 TabPage
            foreach (var tab in tabs.Pages)
            {
                if (tab is AntdUI.TabPage existingTab && existingTab.Text == name)
                {
                    isUpdatingTabs = true;
                    tabs.SelectedTab = existingTab; // 直接跳转到已存在的 TabPage
                    isUpdatingTabs = false;
                    currControl = existingTab.Controls.Count > 0 ? existingTab.Controls[0] as UserControl : null;
                    return;
                }
            }

            // 如果不存在相应的 TabPage，创建新的
            UserControl control = null;
            switch (name)
            {
                case "RSA":
                    control = new RSAForm(this);
                    break;
                case "AES":
                    control = new AESForm();
                    break;
                case "Base64":
                    control = new Base64Form();
                    break;
                default:
                    break;
            }
            if (control != null)
            {
                //容器添加控件，需要调整dpi
                control.Dock = DockStyle.Fill;
                AutoDpi(control);
                AntdUI.TabPage tabPage = new AntdUI.TabPage()
                {
                    Text = name,
                };
                tabPage.Controls.Add(control);
                tabs.Pages.Add(tabPage);
                isUpdatingTabs = true;
                tabs.SelectedTab = tabPage;
                isUpdatingTabs = false;
                currControl = control;
            }
        }

        //private void MenuItem_Click(object sender, EventArgs e)
        //{
        //    ToolStripMenuItem clickedItem = sender as ToolStripMenuItem;
        //    if (clickedItem != null)
        //    {
        //        menuRenderer.SetSelectedMenuItem(clickedItem);
        //        mainMenuStrip.Invalidate(); // 强制重绘 MenuStrip

        //        // 处理界面切换逻辑
        //        if (clickedItem == rsaToolStripMenuItem)
        //        {
        //            ShowForm(rsaForm);
        //        }
        //        else if (clickedItem == aesToolStripMenuItem)
        //        {
        //            ShowForm(aesForm);
        //        }
        //        else if (clickedItem == base64ToolStripMenuItem)
        //        {
        //            ShowForm(base64Form);
        //        }
        //    }
        //}


        //private void ShowForm(Form form)
        //{
        //    // 隐藏所有子窗体
        //    rsaForm.Hide();
        //    aesForm.Hide();
        //    base64Form.Hide();

        //    // 设置子窗体的父容器为当前主窗体
        //    form.TopLevel = false;
        //    form.FormBorderStyle = FormBorderStyle.None;
        //    form.Dock = DockStyle.Fill;

        //    // 添加子窗体到主窗体的容器中
        //    this.Controls.Add(form);
        //    form.Show();
        //}

        //private void rsaToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    ShowForm(rsaForm);
        //}

        //private void aesToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    ShowForm(aesForm);
        //}

        //private void base64ToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    ShowForm(base64Form);
        //}
    }
}
