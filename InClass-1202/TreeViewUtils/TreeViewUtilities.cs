using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeViewUtilsNamespace
{
    public class TreeViewUtilities
    {

        public static void Clear(TreeView view)
        {
            view.Nodes.Clear();
        }

        public static void Init(TreeView view)
        {
            // 4 Indiana Basketball Players
            AddPlayerName(view, "Calbert Chaney");
            AddPlayerName(view, "Damon Bailey");
            AddPlayerName(view, "Joey Brunk");
            AddPlayerName(view, "Nathan Childress");
        }

        public static void AddPlayerName(TreeView view, string playerName)
        {
            foreach (TreeNode playerNode in view.Nodes)
            {
                if (playerNode.Text.ToLower().Equals(playerName.ToLower()))
                {
                    return;
                }
            }
            view.Nodes.Add(playerName);
        }

        public static void AddPlayerNumber(TreeView view, string playerNumber)
        {
            foreach (TreeNode playerNumberNode in view.SelectedNode.Nodes)
            {
                if (playerNumberNode.Text.ToLower().Equals(playerNumber.ToLower()))
                {
                    return;
                }
            }
            view.SelectedNode.Nodes.Add(playerNumber);
        }
    }
}
