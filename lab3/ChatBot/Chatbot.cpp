#include "Chatbot.h"

Chatbot::Chatbot()
{
    message = "";
    reply = "";
}

void Chatbot::set_message(std::string m)
{
    if (m=="")
        throw empty;
    else
        message = m;
}

void Chatbot::template_replies()
{
    if (message == "Привет")
        reply = "Здравствуй, " + n->get_name() + "!";
    if (message == "Пока")
        reply = "До свидания, " + n->get_name() + "!";
    if (message == "Спасибо")
        reply = "Всегда пожалуйста!";
}

void Chatbot::commands_replies()
{

}

void Chatbot::commands_param_replies()
{

}

std::string Chatbot::get_reply()
{

}
