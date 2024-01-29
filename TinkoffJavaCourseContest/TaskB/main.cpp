#include <algorithm>
#include <iostream>
#include <vector>

int main() {
    size_t n, a;
    std::cin >> n;
    std::vector<int> v(n);
    std::vector<int> ans = {1};
    for (size_t i = 0; i < n; ++i) {
        std::cin >> v[i];
    }
    //-----------------------------------------
    std::sort(v.begin(), v.end());
    for (size_t i = 1; i < n; ++i) {
        if (v[i] != v[i - 1]) {
            ans.push_back(1);
        } else {
            ++ans.back();
        }
    }
    //-----------------------------------------
    std::cout << ans.size() << std::endl;
    for (int i = 0; i < ans.size(); ++i) {
        std::cout << ans[i] << " ";
    }
    return 0;
}