#include <array>
#include <string>
#include <vector>

// Round down all provided student scores.
std::vector<int> round_down_scores(std::vector<double> student_scores) {
    // TODO: Implement round_down_scores
    std::vector<int> result;
    for (int i = 0; i < student_scores.size(); i++) {
        result.push_back(static_cast<int>(student_scores[i]));
    }
    return result;
}

// Count the number of failing students out of the group provided.
int count_failed_students(std::vector<int> student_scores) {
    // TODO: Implement count_failed_students
    int total = 0;
    for (int i = 0; i < student_scores.size(); i++) {
        if (student_scores[i] <= 40) total++;
    }
    return total;
}

// Create a list of grade thresholds based on the provided highest grade.
std::array<int, 4> letter_grades(int highest_score) {
    // TODO: Implement letter_grades
    std::array<int, 4> grades;
    int i = (highest_score - 40) / 4;
    grades[0] = 41;
    grades[1] = grades[0] + i;
    grades[2] = grades[1] + i;
    grades[3] = grades[2] + i;
    
    return grades;
}

// Organize the student's rank, name, and grade information in ascending order.
std::vector<std::string> student_ranking(
    std::vector<int> student_scores, std::vector<std::string> student_names) {
    // TODO: Implement student_ranking
    std::vector<std::string> ranking;

    for (int i = 0; i < student_scores.size(); i++) {
        std::string cur = std::to_string(i + 1) + ". " + student_names[i] + ": " + std::to_string(student_scores[i]);
        ranking.push_back(cur);
    }
    
    return ranking;
}

// Create a string that contains the name of the first student to make a perfect
// score on the exam.
std::string perfect_score(std::vector<int> student_scores,
                          std::vector<std::string> student_names) {
    // TODO: Implement perfect_score
    for (int i = 0; i < student_scores.size(); i++) {
        if (student_scores[i] == 100) return student_names[i];
    }
    return "";
}
