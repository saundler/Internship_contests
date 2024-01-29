#include <iostream>

int main() {
    std::string str;
    std::cin >> str;
    char code[4] = {'c', 'o', 'd', 'e'};
    int keyword = 0, password = 0;
    for (int i = 0; i < str.size(); ++i) {
        if (keyword == 4) {
            if (47 < str[i] && str[i] < 58) {
                ++password;
                if (i + 1 == str.size()) {
                    i -= password + keyword - 1;
                    str.erase(i, password + keyword);
                    str.insert(i, "???");
                    break;
                }
                continue;
            } else {
                if (password) {
                    i -= password + keyword;
                    str.erase(i, password + keyword);
                    str.insert(i, "???");
                    i += 3;
                    password = 0;
                }
                keyword = 0;
            }
        }
        if (code[keyword] == str[i]) {
            ++keyword;
        } else {
            if(keyword) {
                --i;
            }
            keyword = 0;
        }
    }
    std::cout << str;
    return 0;
}
