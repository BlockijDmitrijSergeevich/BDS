#include <SFML/Graphics.hpp>

using namespace sf;

View view;

void getplayercoordinateforview(float x, float y) { //������� ��� ���������� ��������� ������
	float tempX = x; float tempY = y;//��������� ����� ������ � ��������� ��, ����� ������ ����

	if (x < 640) tempX = 640;//������� �� ���� ����� �������
	if (x > 640) tempX = 640;
	if (y < 360) tempY = 360;
	if (y > 440) tempY = 440;	

	view.setCenter(tempX, tempY); //������ �� �������, ��������� ��� ����������. 

}

void changeview() {

	if (Keyboard::isKeyPressed(Keyboard::U)) {
		view.zoom(1.0020f); //������������, ����������
		//view.zoom(1.0006f); //���� ����� ����������� ��������������
	}

	if (Keyboard::isKeyPressed(Keyboard::R)) {
		//view.setRotation(90);//����� �� ������ ������� ������
		view.rotate(-1);//���������� ������������ ������ (������������� �������� - � �������� �������)
	}

	if (Keyboard::isKeyPressed(Keyboard::L)) {
		//view.setRotation(90);//����� �� ������ ������� ������
		view.rotate(1);//���������� ������������ ������ (������������� �������� - � �������� �������)
	}

	if (Keyboard::isKeyPressed(Keyboard::I)) {
		view.setSize(1280, 720);//������������� ������ ������ (��� ��������)
	}

	if (Keyboard::isKeyPressed(Keyboard::P)) {
		view.setSize(540, 380);//�������� ������ ������
	}

	if (Keyboard::isKeyPressed(Keyboard::Q)) {
		view.setViewport(sf::FloatRect(0, 0, 0.5f, 1));//����� ������� �������� ���������� ����� ��� ���� �� �����. ����� ������ ������� ��� ���� ������ View � ����������� � ���� ���������� ������ 2.
	}
}