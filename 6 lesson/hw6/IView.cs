using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTime
{
    public interface IView
    {
        void UpdateButtonImage(Button btn, Image img);
        void DisplayMessage(string message);
        void EnableButton(Button btn);
        void DisableButton(Button btn);
        Button[] GetButtons();
    }
}
