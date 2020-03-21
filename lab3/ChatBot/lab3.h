#ifndef CHATBOT_H
#define CHATBOT_H

#include <QMainWindow>

QT_BEGIN_NAMESPACE
namespace Ui { class ChatBot; }
QT_END_NAMESPACE

class ChatBot : public QMainWindow
{
    Q_OBJECT

public:
    ChatBot(QWidget *parent = nullptr);
    ~ChatBot();

private:
    Ui::ChatBot *ui;
};
#endif // CHATBOT_H
