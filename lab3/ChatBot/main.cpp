#include "lab3.h"

#include <QApplication>

int main(int argc, char *argv[])
{
    QApplication a(argc, argv);
    ChatBot w;
    w.show();
    return a.exec();
}
