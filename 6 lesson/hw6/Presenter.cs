using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTime
{
    public class Presenter
    {
        private readonly IView _view;
        private readonly Model _model;

        public Presenter(IView view, Model model)
        {
            _view = view;
            _model = model;
        }

        public void OnButtonClick(Button btn)
        {
            if (btn.Image != null) return;

            var buttons = _view.GetButtons();

            if (_model.IsPlayerTurn)
            {
                _view.UpdateButtonImage(btn, _model.ImgX);
                _model.IsPlayerTurn = false;

                if (_model.CheckWinCondition(buttons))
                {
                    return;
                }

                BotMove();
            }
        }

        private void BotMove()
        {
            var buttons = _view.GetButtons(); 
            _model.MakeBotMove(buttons);
            _model.IsPlayerTurn = true;

            if (_model.CheckWinCondition(buttons)) 
            {
                return;
            }
        }

        public void OnStartGame()
        {
            var buttons = _view.GetButtons();
            foreach (Button btn in buttons)
            {
                _view.EnableButton(btn);
                btn.Image = null;
            }
            _model.IsPlayerTurn = true;
        }

        public void OnModeChanged(bool isHardMode)
        {
            _model.IsHardMode = isHardMode;
        }
    }
}
