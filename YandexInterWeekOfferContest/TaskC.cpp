#include <algorithm>
#include <iostream>
#include <vector>

int main() {
    int n;
    std::cin >> n;
    std::vector<int> v(n + 1);
    for (int i = 1; i < n + 1; ++i) {
        int tmp;
        std::cin >> tmp;
        v[i] = v[tmp] + 1;
    }
    std::cout << std::distance(v.begin(), std::max_element(v.begin(), v.end()));
}