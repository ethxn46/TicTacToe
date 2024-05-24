using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TicTacToeCode : MonoBehaviour
{
    Boolean checker;
    int plusone;

    public Text btnTic1 = null;
    public Text btnTic2 = null;
    public Text btnTic3 = null;
    public Text btnTic4 = null;
    public Text btnTic5 = null;
    public Text btnTic6 = null;
    public Text btnTic7 = null;
    public Text btnTic8 = null;
    public Text btnTic9 = null;

    public Text btnReset = null;
    public Text btnNewGame = null;
    public Text msgFeedback = null;

    public Text txtPlayerX;
    public Text txtPlayerO;

    public void score()
    {
        //==========================================PlayerX=======================================

        if (btnTic1.text == "X" && btnTic2.text == "X" && btnTic3.text == "X")
        {
            btnTic1.color = Color.red;
            btnTic2.color = Color.red;
            btnTic3.color = Color.red;
            msgFeedback.text = "The Winner is Player X!";
            plusone = int.Parse(txtPlayerX.text);
            txtPlayerX.text = Convert.ToString(plusone + 1);
        }

        else if (btnTic1.text == "X" && btnTic4.text == "X" && btnTic7.text == "X")
        {
            btnTic1.color = Color.green;
            btnTic4.color = Color.green;
            btnTic7.color = Color.green;
            msgFeedback.text = "The Winner is Player X!";
            plusone = int.Parse(txtPlayerX.text);
            txtPlayerX.text = Convert.ToString(plusone + 1);
        }

        else if (btnTic1.text == "X" && btnTic5.text == "X" && btnTic9.text == "X")
        {
            btnTic1.color = Color.yellow;
            btnTic5.color = Color.yellow;
            btnTic9.color = Color.yellow;
            msgFeedback.text = "The Winner is Player X!";
            plusone = int.Parse(txtPlayerX.text);
            txtPlayerX.text = Convert.ToString(plusone + 1);
        }

        else if (btnTic3.text == "X" && btnTic5.text == "X" && btnTic7.text == "X")
        {
            btnTic3.color = Color.yellow;
            btnTic5.color = Color.yellow;
            btnTic7.color = Color.yellow;
            msgFeedback.text = "The Winner is Player X!";
            plusone = int.Parse(txtPlayerX.text);
            txtPlayerX.text = Convert.ToString(plusone + 1);
        }

        else if (btnTic2.text == "X" && btnTic5.text == "X" && btnTic8.text == "X")
        {
            btnTic2.color = Color.green;
            btnTic5.color = Color.green;
            btnTic8.color = Color.green;
            msgFeedback.text = "The Winner is Player X!";
            plusone = int.Parse(txtPlayerX.text);
            txtPlayerX.text = Convert.ToString(plusone + 1);
        }

        else if (btnTic3.text == "X" && btnTic6.text == "X" && btnTic9.text == "X")
        {
            btnTic3.color = Color.green;
            btnTic6.color = Color.green;
            btnTic9.color = Color.green;
            msgFeedback.text = "The Winner is Player X!";
            plusone = int.Parse(txtPlayerX.text);
            txtPlayerX.text = Convert.ToString(plusone + 1);
        }

        else if (btnTic4.text == "X" && btnTic5.text == "X" && btnTic6.text == "X")
        {
            btnTic4.color = Color.red;
            btnTic5.color = Color.red;
            btnTic6.color = Color.red;
            msgFeedback.text = "The Winner is Player X!";
            plusone = int.Parse(txtPlayerX.text);
            txtPlayerX.text = Convert.ToString(plusone + 1);
        }

        else if (btnTic7.text == "X" && btnTic8.text == "X" && btnTic9.text == "X")
        {
            btnTic7.color = Color.red;
            btnTic8.color = Color.red;
            btnTic9.color = Color.red;
            msgFeedback.text = "The Winner is Player X!";
            plusone = int.Parse(txtPlayerX.text);
            txtPlayerX.text = Convert.ToString(plusone + 1);
        }

        //==========================================PlayerO=======================================

        else if (btnTic1.text == "O" && btnTic2.text == "O" && btnTic3.text == "O")
        {
            btnTic1.color = Color.red;
            btnTic2.color = Color.red;
            btnTic3.color = Color.red;
            msgFeedback.text = "The Winner is Player O!";
            plusone = int.Parse(txtPlayerO.text);
            txtPlayerO.text = Convert.ToString(plusone + 1);
        }

        else if (btnTic1.text == "O" && btnTic4.text == "O" && btnTic7.text == "O")
        {
            btnTic1.color = Color.green;
            btnTic4.color = Color.green;
            btnTic7.color = Color.green;
            msgFeedback.text = "The Winner is Player O!";
            plusone = int.Parse(txtPlayerO.text);
            txtPlayerO.text = Convert.ToString(plusone + 1);
        }

        else if (btnTic1.text == "O" && btnTic5.text == "O" && btnTic9.text == "O")
        {
            btnTic1.color = Color.yellow;
            btnTic5.color = Color.yellow;
            btnTic9.color = Color.yellow;
            msgFeedback.text = "The Winner is Player O!";
            plusone = int.Parse(txtPlayerO.text);
            txtPlayerO.text = Convert.ToString(plusone + 1);
        }

        else if (btnTic3.text == "O" && btnTic5.text == "O" && btnTic7.text == "O")
        {
            btnTic3.color = Color.yellow;
            btnTic5.color = Color.yellow;
            btnTic7.color = Color.yellow;
            msgFeedback.text = "The Winner is Player O!";
            plusone = int.Parse(txtPlayerO.text);
            txtPlayerO.text = Convert.ToString(plusone + 1);
        }

        else if (btnTic2.text == "O" && btnTic5.text == "O" && btnTic8.text == "O")
        {
            btnTic2.color = Color.green;
            btnTic5.color = Color.green;
            btnTic8.color = Color.green;
            msgFeedback.text = "The Winner is Player O!";
            plusone = int.Parse(txtPlayerO.text);
            txtPlayerO.text = Convert.ToString(plusone + 1);
        }

        else if (btnTic3.text == "O" && btnTic6.text == "O" && btnTic9.text == "O")
        {
            btnTic3.color = Color.green;
            btnTic6.color = Color.green;
            btnTic9.color = Color.green;
            msgFeedback.text = "The Winner is Player O!";
            plusone = int.Parse(txtPlayerO.text);
            txtPlayerO.text = Convert.ToString(plusone + 1);
        }

        else if (btnTic4.text == "O" && btnTic5.text == "O" && btnTic6.text == "O")
        {
            btnTic4.color = Color.red;
            btnTic5.color = Color.red;
            btnTic6.color = Color.red;
            msgFeedback.text = "The Winner is Player O!";
            plusone = int.Parse(txtPlayerO.text);
            txtPlayerO.text = Convert.ToString(plusone + 1);
        }

        else if (btnTic7.text == "O" && btnTic8.text == "O" && btnTic9.text == "O")
        {
            btnTic7.color = Color.red;
            btnTic8.color = Color.red;
            btnTic9.color = Color.red;
            msgFeedback.text = "The Winner is Player O!";
            plusone = int.Parse(txtPlayerO.text);
            txtPlayerO.text = Convert.ToString(plusone + 1);
        }
    }


    public void btnTic1_Click()
    {
        if (checker == false)
        {
            btnTic1.text = "X";
            checker = true;
        }
        else
        {
            btnTic1.text = "O";
            checker = false;
        }
        score();
    }

    public void btnTic2_Click()
    {
        if (checker == false)
        {
            btnTic2.text = "X";
            checker = true;
        }
        else
        {
            btnTic2.text = "O";
            checker = false;
        }
        score();
    }

    public void btnTic3_Click()
    {
        if (checker == false)
        {
            btnTic3.text = "X";
            checker = true;
        }
        else
        {
            btnTic3.text = "O";
            checker = false;
        }
        score();
    }

    public void btnTic4_Click()
    {
        if (checker == false)
        {
            btnTic4.text = "X";
            checker = true;
        }
        else
        {
            btnTic4.text = "O";
            checker = false;
        }
        score();
    }

    public void btnTic5_Click()
    {
        if (checker == false)
        {
            btnTic5.text = "X";
            checker = true;
        }
        else
        {
            btnTic5.text = "O";
            checker = false;
        }
        score();
    }

    public void btnTic6_Click()
    {
        if (checker == false)
        {
            btnTic6.text = "X";
            checker = true;
        }
        else
        {
            btnTic6.text = "O";
            checker = false;
        }
        score();
    }

    public void btnTic7_Click()
    {
        if (checker == false)
        {
            btnTic7.text = "X";
            checker = true;
        }
        else
        {
            btnTic7.text = "O";
            checker = false;
        }
        score();
    }

    public void btnTic8_Click()
    {
        if (checker == false)
        {
            btnTic8.text = "X";
            checker = true;
        }
        else
        {
            btnTic8.text = "O";
            checker = false;
        }
        score();
    }

    public void btnTic9_Click()
    {
        if (checker == false)
        {
            btnTic9.text = "X";
            checker = true;
        }
        else
        {
            btnTic9.text = "O";
            checker = false;
        }
        score();
    }

    public void btnReset_Click()
    {
        btnTic1.text = "";
        btnTic2.text = "";
        btnTic3.text = "";
        btnTic4.text = "";
        btnTic5.text = "";
        btnTic6.text = "";
        btnTic7.text = "";
        btnTic8.text = "";
        btnTic9.text = "";

        btnTic1.color = Color.black;
        btnTic2.color = Color.black;
        btnTic3.color = Color.black;
        btnTic4.color = Color.black;
        btnTic5.color = Color.black;
        btnTic6.color = Color.black;
        btnTic7.color = Color.black;
        btnTic8.color = Color.black;
        btnTic9.color = Color.black;
    }
    public void btnNewGame_Click()
    {
        txtPlayerX.text = "";
        txtPlayerO.text = "";
    }
}
