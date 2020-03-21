#ifndef USERNAME_H
#define USERNAME_H

#include <string>

class Username
{
    std::string name;
public:
    enum errors {empty};
    Username();
    void set_name(std::string n);
    std::string get_name();
};

#endif // USERNAME_H
