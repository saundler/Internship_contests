#include <algorithm>
#include <iostream>
#include <vector>

struct Applicant {
    int number;
    int points;
    int programm = -1;
    std::vector<int> wish_list;
};

int main() {
    int n, k;
    std::cin >> n >> k;
    std::vector<Applicant> applicants(n);
    std::vector<int> programms(k);
    for (int i = 0; i < k; ++i) {
        std::cin >> programms[i];
    }
    for (int i = 0; i < n; ++i) {
        applicants[i].number = i;
        std::cin >> applicants[i].points;
        std::cin >> k;
        std::vector<int> wish_list(k);
        for (int j = 0; j < k; ++j) {
            std::cin >> wish_list[j];
        }
        applicants[i].wish_list = wish_list;
    }
    std::sort(applicants.begin(), applicants.end(), [](const Applicant &a, const Applicant &b) {
        return std::tie(a.points, a.number) < std::tie(b.points, b.number);
    });
    for (auto &applicant: applicants) {
        for (int programm_number : applicant.wish_list) {
            if (programms[programm_number - 1] > 0) {
                --programms[programm_number - 1];
                applicant.programm = programm_number;
                break;
            }
        }
    }
    std::sort(applicants.begin(), applicants.end(), [](const Applicant &a, const Applicant &b) {
        return a.number < b.number;
    });
    for (auto &applicant: applicants) {
        std::cout << applicant.programm << " ";
    }
}

