#include <algorithm>
#include <iostream>
#include <vector>

int main() {
    int n, d, c, s;
    std::cin >> n;
    std::vector<std::pair<int, int>> presents;
    for (int i = 0; i < n; ++i) {
        std::cin >> d >> c >> s;
        presents.push_back({d + c, s});
    }
    sort(presents.begin(), presents.end(), [](std::pair<int, int> &a, std::pair<int, int> &b) {
        return a.second < b.second || (a.second == b.second && a.first < b.first);
    });
    int day = presents.front().first;
    for (auto& present: presents) {
        if (present.first > day) {
            day = present.first;
        }
        if (day > present.second) {
            std::cout << "NO";
            return 0;
        }
        ++day;
    }
    std::cout << "YES";
    return 0;
}