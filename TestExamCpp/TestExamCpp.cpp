// TestExamCpp.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//
#define _CRT_SECURE_NO_WARNINGS
#include <iostream>

struct Node {
	int data;
	char name[10];
	Node* next;
	Node* prev;
};
struct doubledList {
	Node* head = nullptr;
	Node* tail = nullptr;
};

void addByData(doubledList* list, int data, char name[10]) {
	Node* node = (Node*)malloc(sizeof(Node));
	node->data = data;
	strcpy_s(node->name, name);
	node->next = NULL;
	node->prev = NULL;
	if (list->head == NULL)
	{
		list->head = node;
		list->tail = node;
	}
	else
	{
		if (list->head->data >= node->data)
		{
			node->next = list->head;
			list->head->prev = node;
			list->head = node;
		}
		else if (list->tail->data <= node->data)
		{
			node->prev = list->tail;
			list->tail->next = node;
			list->tail = node;
		}
		else {
			Node* curNode = list->head;
			while (curNode != NULL) {
				if (node->data >= curNode->data && node->data <= curNode->next->data)
				{
					node->next = curNode->next;
					curNode->next->prev = node;
					curNode->next = node;
					break;
				}
				else
					curNode = curNode->next;
			}
		}

	}

}
void print(struct doubledList* list) {
	if (list->head == NULL)
		std::cout << "empty";
	else
	{
		Node* currentNode = list->head;
		while (currentNode != NULL) {
			std::cout << currentNode->data << ": " << currentNode->name << std::endl;
			currentNode = currentNode->next;
		}
	}
	std::cout << std::endl;
}
int main()
{
	doubledList* list = (doubledList*)malloc(sizeof(struct doubledList));
	list->head = NULL;
	list->tail = NULL;

	while (true)
	{
		printf_s("enter command \n");
		printf_s("1. add Node \n");
		printf_s("2. print \n");

		int code;
		scanf_s("%d", &code);
		if (code == 1)
		{
			int id;
			char name[10];
			printf("enter ID Name: ");
			scanf("%d %9s", &id, name);

			addByData(list, id, name);
		}
		else if (code == 2)
			print(list);

		printf_s("\n");
	}
	/*while(true)
	{
		std::cout << "Input command: \n" << std::endl;
		std::cout << "1. add Node" << std::endl;
		std::cout << "2. print" << std::endl;

		int code;
		std::cin >> code;
		if (code == 1)
		{
			int id;
			char name[10];
			std::cout << "enter id: ";
			std::cin >> id;
			std::cout << std::endl;
			std::cout << "enter name: ";
			std::cin >> name;
			addByData(list, id, name);
		}
		else if (code == 2)
			print(list);

		std::cout << std::endl;
	}*/
};

// Запуск программы: CTRL+F5 или меню "Отладка" > "Запуск без отладки"
// Отладка программы: F5 или меню "Отладка" > "Запустить отладку"

// Советы по началу работы 
//   1. В окне обозревателя решений можно добавлять файлы и управлять ими.
//   2. В окне Team Explorer можно подключиться к системе управления версиями.
//   3. В окне "Выходные данные" можно просматривать выходные данные сборки и другие сообщения.
//   4. В окне "Список ошибок" можно просматривать ошибки.
//   5. Последовательно выберите пункты меню "Проект" > "Добавить новый элемент", чтобы создать файлы кода, или "Проект" > "Добавить существующий элемент", чтобы добавить в проект существующие файлы кода.
//   6. Чтобы снова открыть этот проект позже, выберите пункты меню "Файл" > "Открыть" > "Проект" и выберите SLN-файл.
