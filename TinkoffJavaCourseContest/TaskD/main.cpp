#include <algorithm>
#include <cmath>
#include <iostream>
#include <vector>

int find_parent(int index, int length, std::vector<std::vector<int>>& parents) {
    int deg = 0;
    for (; length > 0; length /= 2) {
        if (length % 2) {
            index = parents[deg][index];
        }
        ++deg;
    }
    return index;
}

void build(int index, std::vector<int>& parent, std::vector<int>& height, std::vector<std::vector<int>>& ribs, int dad = -1) {
    if (dad == -1) {
        parent[index] = index;
        height[index] = 0;
    } else {
        parent[index] = dad;
        height[index] = height[dad] + 1;
    }
    for (auto i: ribs[index]) {
        if (i != dad) {
            build(i, parent, height, ribs, index);
        }
    }
}

int main() {
    std::ios::sync_with_stdio(false);
    std::cin.tie(nullptr);
    std::cout.tie(nullptr);
    int n, a, b, index;
    std::cin >> n;
    std::vector<int> parent(n), height(n);
    std::vector<std::vector<int>> ribs(n), parents;
    for (int i = 0; i < n - 1; ++i) {
        std::cin >> a >> b;
        ribs[a - 1].push_back(b - 1);
        ribs[b - 1].push_back(a - 1);
    }
    //----------------------------------------------
    build(0, parent, height, ribs);
    int log_height = ceil(log(n));
    parents.resize(log_height, std::vector<int>(n));
    for (int i = 0; i < log_height; ++i) {
        if (!i) {
            for (int j = 0; j < n; ++j) {
                parents[i][j] = parent[j];
            }
        } else {
            for (int j = 0; j < n; ++j) {
                parents[i][j] = parents[i - 1][parents[i - 1][j]];
            }
        }
    }
    //----------------------------------------------
    std::cin >> n;
    for (int i = 0; i < n; ++i) {
        std::cin >> a >> b;
        --a;
        --b;
        if (height[a] >= height[b]) {
            std::cout << parent[a] + 1 << "\n";
        } else {
            index = find_parent(b, height[b] - height[a], parents);
            if (index != a) {
                std::cout << parent[a] + 1 << "\n";
            } else {
                std::cout << find_parent(b, height[b] - height[a] - 1, parents) + 1 << "\n";
            }
        }
    }
    return 0;
}
