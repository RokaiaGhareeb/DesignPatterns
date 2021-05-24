using DPday01lab.DesignPattern.Strategy.Strategies;
using DPday01lab.Entities;
using DPday01lab.DesignPattern.Decorator.ConcreteDecorators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DPday01lab
{
    public partial class Form1 : Form
    {
        // ball and referee (publisher and subscriber -- observer)
        BallPosition ballPosition;
        Ball ball;
        Refree refree;

        // team strategy (strategy)
        Team team;
        AttackStrategy attackStrategy;
        DefendStrategy defendStrategy;

        Goalkeeper goalkeeper;
        FieldPlayer filedplayer;

        public Form1()
        {
            ballPosition = new BallPosition() { X = 10, Y = 10, Z = 10 };
            ball = new Ball() { position = ballPosition };
            refree = new Refree() { ballPosition = ballPosition };
            ball.Attach(refree);

            team = new Team();
            attackStrategy = new AttackStrategy();
            defendStrategy = new DefendStrategy();
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ball.moveBall(ball.position.X - 1, ball.position.X - 1, ball.position.X - 1);
            label1.Text = $"ball moved to ({ball.position.X}, {ball.position.Y}, {ball.position.Z})";
            label2.Text = $"refree see ball at ({refree.ballPosition.X}, {refree.ballPosition.Y}, {refree.ballPosition.Z})";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ball.moveBall(ball.position.X + 1, ball.position.X + 1, ball.position.X + 1);
            label1.Text = $"ball moved to ({ball.position.X}, {ball.position.Y}, {ball.position.Z})";
            label2.Text = $"refree see ball at ({refree.ballPosition.X}, {refree.ballPosition.Y}, {refree.ballPosition.Z})";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            team.SetStrategy(attackStrategy);
            label6.Text = team.changeStrategy();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            team.SetStrategy(defendStrategy);
            label6.Text = team.changeStrategy();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            goalkeeper = new Goalkeeper();
            filedplayer = null;
            label8.Text = goalkeeper.PassBall();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            filedplayer = new FieldPlayer();
            goalkeeper = null;
            label8.Text = filedplayer.PassBall();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (goalkeeper != null)
            {
                var forward = new Forward(goalkeeper);
                label8.Text = forward.PassBall();
            }
            else
            {
                var forward = new Forward(filedplayer);
                label8.Text = forward.PassBall();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (goalkeeper != null)
            {
                var forward = new Forward(goalkeeper);
                var defender = new Defender(forward);
                label8.Text = defender.PassBall();
            }
            else
            {
                var forward = new Forward(filedplayer);
                var defender = new Defender(forward);
                label8.Text = defender.PassBall();
            }
        }
    }
}
