#include <iostream>
#include <cstdint>

int main() {
    int64_t n, m, c2, c5;
    std::cin >> n >> m >> c2 >> c5;
    if (n >= m) {
        std::cout << 0;
    } else if (c2 * 4 <= c5) {
        std::cout << (m - n) * c2;
    } else {
        std::cout << (m - n) / 4 * c5 + (c5 <= c2 * ((m - n) % 4) ? c5 : c2 * ((m - n) % 4));
    }
}