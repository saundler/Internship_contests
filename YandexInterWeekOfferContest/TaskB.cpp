#include <algorithm>
#include <iostream>
#include <vector>

int main() {
    int n, k;
    std::cin >> n >> k;
    std::vector<int> v(n);
    std::vector<int> r;
    for (int i = 0; i < n; ++i) {
        std::cin >> v[i];
    }
    std::sort(v.begin(), v.end());
    for (int i = n - k - 1, j = 0; i < n; ++i, ++j) {
        r.push_back(v[i] - v[j]);
    }
    std::cout << *std::min_element(r.begin(), r.end());
}