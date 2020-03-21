#include "Username.h"

Username::Username()
{
    name = "";
}

void Username::set_name(std::string n)
{
    if (n == "")
        throw empty;
    else
        name = n;
}

std::string Username::get_name()
{
    return name;
}
