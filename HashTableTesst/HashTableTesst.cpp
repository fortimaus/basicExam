// HashTableTesst.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include <vector>
#include <iostream>

class HashTable {
private:
    std::vector<std::pair<int, std::string>> table;
    int capacity;
    int size;

    int hash(int key) {
        return key % capacity;
    }

public:
    HashTable(int size) : capacity(size), size(0) {
        table.resize(capacity, { -1, "" });  // -1 означает "пусто"
    }

    void insert(int key, const std::string& value) {
        if (size >= capacity) {
            std::cerr << "Таблица переполнена!\n";
            return;
        }

        int index = hash(key);
        while (table[index].first != -1 && table[index].first != key) {
            index = (index + 1) % capacity;  // Линейный поиск
        }

        if (table[index].first == -1) {
            size++;  // Увеличиваем только если добавляем новый элемент
        }
        table[index] = { key, value };
    }

    std::string get(int key) {
        int index = hash(key);
        int start = index;
        while (table[index].first != -1) {
            if (table[index].first == key) {
                return table[index].second;
            }
            index = (index + 1) % capacity;
            if (index == start) break;  // Прошли весь массив
        }
        return "Не найдено";
    }
};

int main() {
    HashTable ht(10);
    ht.insert(5, "Apple");
    ht.insert(15, "Banana");  // Коллизия (5 и 15 → одна ячейка)
    ht.insert(25, "Orange");  // Ещё одна коллизия

    std::cout << "key 5: " << ht.get(5) << "\n";    // Apple
    std::cout << "key 15: " << ht.get(15) << "\n";  // Banana
    std::cout << "key 25: " << ht.get(25) << "\n";  // Orange

    return 0;
}

// Запуск программы: CTRL+F5 или меню "Отладка" > "Запуск без отладки"
// Отладка программы: F5 или меню "Отладка" > "Запустить отладку"

// Советы по началу работы 
//   1. В окне обозревателя решений можно добавлять файлы и управлять ими.
//   2. В окне Team Explorer можно подключиться к системе управления версиями.
//   3. В окне "Выходные данные" можно просматривать выходные данные сборки и другие сообщения.
//   4. В окне "Список ошибок" можно просматривать ошибки.
//   5. Последовательно выберите пункты меню "Проект" > "Добавить новый элемент", чтобы создать файлы кода, или "Проект" > "Добавить существующий элемент", чтобы добавить в проект существующие файлы кода.
//   6. Чтобы снова открыть этот проект позже, выберите пункты меню "Файл" > "Открыть" > "Проект" и выберите SLN-файл.
