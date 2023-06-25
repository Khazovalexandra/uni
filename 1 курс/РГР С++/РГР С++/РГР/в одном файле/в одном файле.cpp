#include <iostream>
#include <cmath>
#include <string>
#include <locale>

using namespace std;
class log0
{
public:
	bool x1, x2, x3;
	log0 (bool a, bool b, bool c)
	{
		x1 = a;
		x2 = b;
		x3 = c;
	}
	bool vixod1()
	{
		if (((x1 == 1) || (x1 == 0)) && ((x2 == 1) || (x2 == 0))) return !(x1 && x2);
		else cout << "Ошибка" << endl;
	}
	bool vixod2()
	{
		if (((x2 == 1) || (x2 == 0)) && ((x3 == 1) || (x3 == 0))) return x2 && x3;
		else cout << "Ошибка" << endl;
	};
};
int main()
{
	setlocale(LC_ALL, "Russian");
	cout << "   Работу выполнила студентка 1 курса группы ИС-29" << endl;
	cout << "   Хазова Александра Сергеевна" << endl;
	cout << "   Вариант 21" << endl;
	cout << "   Текст задания: " << endl;
	cout << "    Напишите класс log2, описывающий логическую схему" << endl;
	cout << "    с тремя входами и двумя выходами" << endl;
	cout << "        х1_______1|----|" << endl;
	cout << "        x2________|&   |.___Y1" << endl;
	cout << "             |    |____|" << endl;
	cout << "             |" << endl;                      //логическая схема
	cout << "             |___2|----|" << endl;
	cout << "        x3________|&   |.__Y2" << endl;
	cout << "                  |____|" << endl;

	bool x1, x2, x3;       //тип логических переменных
	cout << "Входные сигналы: " << endl; //по всему проекту на вход принимаются только значения 0 и 1
	cin >> x1;
	cin >> x2;
	cin >> x3;
	log0 v(x1, x2, x3);
	cout << "Выходные сигналы: " << endl;
	cout << "y1 = " << v.vixod1() << endl;
	cout << "y2 = " << v.vixod2() << endl;
	system("pause");
	return 0;
}