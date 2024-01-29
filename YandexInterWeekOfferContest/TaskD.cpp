#include <algorithm>
#include <iostream>
#include <vector>
#include <cstdint>

int main() {
    int64_t k, n, m;
    std::cin >> k >> n >> m;
    std::vector<std::pair<int64_t, int64_t>> v(n);
    for (int64_t i = 0; i < n; ++i) {
        std::cin >> v[i].second >> v[i].first;
    }
    std::sort(v.begin(), v.end(), [](std::pair<int64_t, int64_t> &a, std::pair<int64_t, int64_t> &b) {
        return std::tie(a.first, a.second) < std::tie(b.first, b.second);
    });
    for (int64_t i = 0; i < n; ++i) {
        if (v[i] == *(v.end() - 1) || v[i].first != v[i + 1].first) {
            if (m == 0) {
                std::cout << -1;
                return 0;
            }
            v[i].first = 0;
            --m;
        } else  {
            v[i].second = v[i + 1].second - v[i].second;
        }
    }
    std::sort(v.begin(), v.end(), [](std::pair<int64_t, int64_t> &a, std::pair<int64_t, int64_t> &b) {
        return  a.second >  b.second;
    });
    for (int64_t i = 0; i < n && m > 0; ++i) {
        if (v[i].first != 0) {
            v[i].first = 0;
            --m;
        }
    }
    int64_t sum = 0;
    for (int64_t i = 0; i < n; ++i) {
        if (v[i].first != 0) {
            sum += v[i].second;
        }
    }
    std::cout << sum ;
}