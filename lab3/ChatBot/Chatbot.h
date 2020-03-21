#ifndef CHATBOT_H
#define CHATBOT_H

#include <string>
#include "username.h"

class Username;
class Calculator;

class Chatbot
{
    Username *n;
    Calculator *c;
    std::string message;
    std::string reply;
public:
    enum errors {empty};
    Chatbot();
    void set_message(std::string m);
    void template_replies();
    void commands_replies();
    void commands_param_replies();
    std::string get_reply();
};

#endif // CHATBOT_H
