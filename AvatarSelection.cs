using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Chess
{
    public partial class AvatarSelection : Form
    {
        public event EventHandler<Image> AvatarSelected;
        public AvatarSelection()
        {
            InitializeComponent();
            LeftArrows.Click += ButtonClick;
            RightArrows.Click += ButtonClick;
            ApplyButtons.Click += ButtonClick;
        }
        string[] avatarKeys = { "zhongli", "liuyun", "yoimiya", "yelan", "Gaming", "venti", "shogun", "shinobu", "playerboy", "nahida", "kazuha", "hutao", "playergirl", "bennett", "cyno", "eula", "klee", "ganyu" };
        int position = 0;    
        public static Image SelectedAvatar { get; private set; } = null;
        public AvatarSelection(Image defaultAvatar) : this()
        {
            PREVIEW.Image = defaultAvatar;
        }  
        public void ButtonClick(object sender, EventArgs e)
        {
            switch (((Button)sender).Name)
            {
                case "RightArrows":
                    position++;
                    break;
                case "LeftArrows":
                    position--;
                    break;
                default:
                    Image selectedAvatar = Properties.Resources.ResourceManager.GetObject(avatarKeys[position]) as Image;
                    AvatarSelected?.Invoke(this, selectedAvatar);
                    this.Close();
                    break;
            }
            if (position < 0)
                position = avatarKeys.Length - 1;

            if (position >= avatarKeys.Length)
                position = 0;
            PREVIEW.Image = Properties.Resources.ResourceManager.GetObject(avatarKeys[position]) as Image;
        }
    }
}
