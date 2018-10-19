using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerString
{
    public class TextController
    {
        #region 텍스트 색깔 변경
        /// <summary>
        /// box.Text가 headText와 같은 경우 inputText 값을 넣는다. 
        /// color는 string.Empty 값이 headText이면 Silver를 입력, inputText인 경우 Black을 입력한다.
        /// </summary>
        /// <param name="box"></param>
        /// <param name="str"></param>
        /// <param name="empty"></param>
        /// <param name="color"></param>
        public void ChangeTextColor(TextBox box, string headText, string inputText, Color color)
        {
            if (box.Text == headText)
            {
                box.Text = inputText;
                box.ForeColor = color;
            }
        }   
            #endregion



            #region 비밀번호 * 표시
            public void TextPwChar(TextBox textBox)
        {
            textBox.PasswordChar = '*';
        }
        #endregion
    }
}
