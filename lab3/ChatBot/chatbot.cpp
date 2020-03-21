#include "chatbot.h"
#include "ui_chatbot.h"

ChatBot::ChatBot(QWidget *parent)
    : QMainWindow(parent)
    , ui(new Ui::ChatBot)
{
    ui->setupUi(this);
}

ChatBot::~ChatBot()
{
    delete ui;
}

