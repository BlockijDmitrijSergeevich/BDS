#include <SFML/Graphics.hpp>
#include "map.h"
#include "view.h"
#include <iostream>
#include <sstream>
#include "menu.h"

using namespace sf;
using namespace std;


////////////////////////////////////����� ����� ��������//////////////////////////
class Entity {
public:
	float dx, dy, x, y, speed, moveTimer, CurrentFrame = 0;
	int w, h, health;
	bool life, isMove, onGround;
	Texture texture;
	Sprite sprite;
	String name;// �������� ������ �� ����� � ����� ������� ���� �������� � update � ����������� �� �����
	Entity(Image &image, float X, float Y, int W, int H, String Name) 
	{
		x = X; y = Y; w = W; h = H; name = Name; moveTimer = 0;
		speed = 0; health = 100; dx = 0; dy = 0;
		life = true; onGround = false; isMove = false;
		texture.loadFromImage(image);
		sprite.setTexture(texture);
		sprite.setOrigin(w / 2, h / 2);
	}
	FloatRect getRect() {
		return FloatRect(x, y, w, h);
	}
};
////////////////////////////////////////////////////����� ������////////////////////////
class Player :public Entity {
public:
	enum { left, right, up, down, jump, stay } state;//��������� ��� ������������ - ��������� �������
	int playerScore;//��� ���������� ����� ���� ������ � ������
	Player(Image &image, float X, float Y, int W, int H, String Name) :Entity(image, X, Y, W, H, Name) {
		playerScore = 0;
		state = stay;
		if (name == "Player1") {
			sprite.setTextureRect(IntRect(0, 0, w, h));
		}
	}
	void control(float time) {
		if (life) {
			if (Keyboard::isKeyPressed(Keyboard::Left)) {
				state = left; speed = 0.1;
				CurrentFrame += 0.005*time;
				if (CurrentFrame > 3) CurrentFrame -= 3;
				sprite.setTextureRect(IntRect(40 * int(CurrentFrame), 32, w, h));
				sprite.move(-0.1*time, 0);
			}
			if (Keyboard::isKeyPressed(Keyboard::Right)) {
				state = right; speed = 0.1;
				CurrentFrame += 0.005*time;
				if (CurrentFrame > 3) CurrentFrame -= 3;
				sprite.setTextureRect(IntRect(40 * int(CurrentFrame), 0, w, h));
				sprite.move(-0.1*time, 0);
			}
			if ((Keyboard::isKeyPressed(Keyboard::Up)) && (onGround)) {
				state = jump; dy = -0.6; onGround = false;
			}
			if (Keyboard::isKeyPressed(Keyboard::Down)) {
				state = down;
			}
			changeview();
		}
	}

	void update(float time)
	{
		control(time);//������� ���������� ����������
		switch (state)//��� �������� ��������� �������� � ����������� �� ���������
		{
		case right:dx = speed; break;//��������� ���� ������
		case left:dx = -speed; break;//��������� ���� �����
		case up: break;//����� ��������� �������� ������ (�������� �� ��������)
		case down: dx = 0; break;//����� ��������� �� ����� ������ ��������� (�������� �� ��������)
		case stay: break;//� ����� ����		
		}
		x += dx * time;
		checkCollisionWithMap(dx, 0);//������������ ������������ �� �
		y += dy * time;
		checkCollisionWithMap(0, dy);
		sprite.setPosition(x + w / 2, y + h / 2); //������ ������� ������� � ����� ��� ������
		if (health <= 0) { 
			life = false;
			speed = 0;
		}
		if (!isMove) { speed = 0; }
		//if (!onGround) { dy = dy + 0.0015*time; }//������� � ����� ������ ����������� � �����
		if (life) { getplayercoordinateforview(x, y); }
		dy = dy + 0.0015*time;//��������� ������������� � �����
	}
	void checkCollisionWithMap(float Dx, float Dy)//� ��� �������� ������������ � ������
	{
		for (int i = y / 32; i < (y + h) / 32; i++)
			for (int j = x / 32; j < (x + w) / 32; j++)
			{
				if (TileMap[i][j] == '0' || TileMap[i][j] == 'e' || TileMap[i][j] == 'a' || TileMap[i][j] == 'b')
				{
					if (Dy > 0) { y = i * 32 - h;  dy = 0; onGround = true; }//�� Y ����=>���� � ���(����� �� �����) ��� ������. � ���� ������ ���� ���������� ��������� � ��������� ��� �� �����, ��� ���� ������� ��� �� �� ����� ��� ����� ����� ����� �������
					if (Dy < 0) { y = i * 32 + 32;  dy = 0; }//������������ � �������� ������ �����(����� � �� �����������)
					if (Dx > 0) { x = j * 32 - w; }//� ������ ����� �����
					if (Dx < 0) { x = j * 32 + 32; }// � ����� ����� �����
				}   
				if (TileMap[i][j] == 'm')
				{
					playerScore++;
					TileMap[i][j] = ' ';
				}
				if (TileMap[i][j] == 'd')
				{
					health = -100;
				}
				
			}
	}
};
class Enemy :public Entity {
public:
	Enemy(Image &image, float X, float Y, int W, int H, String Name) :Entity(image, X, Y, W, H, Name) {
		if (name == "EasyEnemy") {
			sprite.setTextureRect(IntRect(0, 0, w, h));
			dx = 0.1;//���� ��������.���� ������ ������ ���������
		}
		if (name == "jumpImage")
		{
			sprite.setTextureRect(IntRect(0, 0, w, h));
		}
	}
	void checkCollisionWithMap(float Dx, float Dy)//� ��� �������� ������������ � ������
	{
		for (int i = y / 32; i < (y + h) / 32; i++)//���������� �� ��������� �����
			for (int j = x / 32; j < (x + w) / 32; j++)
			{
				if (TileMap[i][j] == '0' || TileMap[i][j] == 'e' || TileMap[i][j] == 'a' || TileMap[i][j] == 'b')//���� ������� ��� ������ �����, ��
				{
					if (Dy > 0) { y = i * 32 - h; }//�� Y ����=>���� � ���(����� �� �����) ��� ������. � ���� ������ ���� ���������� ��������� � ��������� ��� �� �����, ��� ���� ������� ��� �� �� ����� ��� ����� ����� ����� �������
					if (Dy < 0) { y = i * 32 + 32; }//������������ � �������� ������ �����(����� � �� �����������)
					if (Dx > 0) { x = j * 32 - w; dx = -0.1; sprite.scale(-1, 1); }//� ������ ����� �����
					if (Dx < 0) { x = j * 32 + 32; dx = 0.1; sprite.scale(-1, 1); }// � ����� ����� �����
				}
			}
	}
	void update(float time)
	{
		if (name == "EasyEnemy") {
		moveTimer += time;if (moveTimer>3000){ dx *= -1; moveTimer = 0; sprite.scale(-1, 1);}//������ ����������� �������� ������ 3 ���
			checkCollisionWithMap(dx, 0);//������������ ������������ �� �
			x += dx * time;
			sprite.setPosition(x + w / 2, y + h / 2); //������ ������� ������� � ����� ��� ������
		}
	}

	void updateJump(float time)
	{
		if (name == "jumpImage") {//��� ��������� � ����� ������ ������ ����� �����
			sprite.setPosition(x + w / 2, y + h / 2); //������ ������� ������� � ����� ��� ������
		}
	}

};
class MovingPlatform : public Entity {//����� ���������� ���������
public:
	MovingPlatform(Image &image, float X, float Y, int W, int H, String Name) :Entity(image, X, Y, W, H, Name) {
		sprite.setTextureRect(IntRect(0, 0, W, H));//������������� 
		dx = 0.08;//����������� ��������� �� �
	}
	void checkCollisionWithMap(float Dx, float Dy)//� ��� �������� ������������ � ������
	{
		for (int i = y / 32; i < (y + h) / 32; i++)//���������� �� ��������� �����
			for (int j = x / 32; j < (x + w) / 32; j++)
			{
				if (TileMap[i][j] == '0' || TileMap[i][j] == 'e' || TileMap[i][j] == 'a' || TileMap[i][j] == 'b')//���� ������� ��� ������ �����, ��
				{
					if (Dy > 0) { y = i * 32 - h; }//�� Y ����=>���� � ���(����� �� �����) ��� ������. � ���� ������ ���� ���������� ��������� � ��������� ��� �� �����, ��� ���� ������� ��� �� �� ����� ��� ����� ����� ����� �������
					if (Dy < 0) { y = i * 32 + 32; }
					if (Dx > 0) { x = j * 32 - w; dx = -0.1; sprite.scale(-1, 1); }
					if (Dx < 0) { x = j * 32 + 32; dx = 0.1; sprite.scale(-1, 1); }
				}
			}
	}
	void update(float time)//������� ���������� ���������.
	{
		x += dx * time;
		checkCollisionWithMap(dx, 0);
		sprite.setPosition(x + w / 2, y + h / 2);//������ ������� �������
	}
	void updatePlatform(float time)
	{
		if (name == "MovingPlatform") {//��� ��������� � ����� ������ ������ ����� �����
			sprite.setPosition(x + w / 2, y + h / 2); //������ ������� ������� � ����� ��� ������
			
		}
	}
};

bool startGame()
{
	RenderWindow window(VideoMode(1920, 1080), "My game", Style::Fullscreen);
	view.reset(FloatRect(0, 0, 1280, 720));
	menu(window);

	Image map_image;
	map_image.loadFromFile("map_.png");

	Texture map;
	map.loadFromImage(map_image);

	Sprite s_map;
	s_map.setTexture(map);

	Image heroImage;
	heroImage.loadFromFile("MilesTailsPrower.png");
	Player p(heroImage, 32, 700, 40, 28, "Player1");

	Image easyEnemyImage;
	easyEnemyImage.loadFromFile("shamaich.png");
	easyEnemyImage.createMaskFromColor(Color(255, 0, 0));
	Enemy easyEnemy(easyEnemyImage, 750, 701, 138, 64, "EasyEnemy");

	Image movePlatformImage;
	movePlatformImage.loadFromFile("platform.png");
	MovingPlatform movePlatform(movePlatformImage, 32, 96, 160, 32, "MovingPlatform");

	Image movePlatformImage2;
	movePlatformImage2.loadFromFile("platform.png");
	MovingPlatform movePlatform2(movePlatformImage2, 480, 96, 160, 32, "MovingPlatform");

	Image jumpImageImage;
	jumpImageImage.loadFromFile("jump.png");
	jumpImageImage.createMaskFromColor(Color(255, 0, 0));
	Enemy jumpImage(jumpImageImage, 32, 384, 64, 32, "jumpImage");

	Image jumpImageImage2;
	jumpImageImage2.loadFromFile("jump.png");
	jumpImageImage2.createMaskFromColor(Color(255, 0, 0));
	Enemy jumpImage2(jumpImageImage2, 1088, 576, 64, 32, "jumpImage");

	Font font, font2;
	font.loadFromFile("CyrilicOld.ttf"); font2.loadFromFile("CyrilicOld.ttf"); 
	Text text("", font, 20); Text text2("", font2, 60);
	text.setFillColor(Color::Yellow); text2.setFillColor(Color::Red);
	text.setStyle(Text::Bold | Text::Underlined);text2.setStyle(Text::Bold | Text::Underlined);

	

	Clock clock;
	Clock gameTimeClock;
	int gameTime = 0;
	while (window.isOpen())
	{
		float time = clock.getElapsedTime().asMicroseconds();
		if (p.life) gameTime = gameTimeClock.getElapsedTime().asSeconds();//������� ����� � �������� ��� ������, ���� ��� �����. 
		clock.restart();
		time = time / 800;
		Event event;
		while (window.pollEvent(event))
		{
			if (event.type == Event::Closed)
				window.close();
		}


		if ((movePlatform.name == "MovingPlatform") && (movePlatform.getRect().intersects(p.getRect())))//���� ����� ���������� � �������� ������ � ��� ����� ������� movingplatform
		{

			if ((p.dy > 0) || (p.onGround == false))//��� ���� ����� ��������� � ��������� ����� ������, �.� ������ ����
				if (p.y + p.h < movePlatform.y + movePlatform.h)//���� ����� ��������� ���� ���������
				{
					p.y = movePlatform.y - p.h + 3; p.x += movePlatform.dx*time; p.dy = 0; p.onGround = true; // �� ����������� ������ ���, ����� �� ��� �� ����� �� ���������
				}
		}
		if ((movePlatform2.name == "MovingPlatform") && (movePlatform2.getRect().intersects(p.getRect())))//���� ����� ���������� � �������� ������ � ��� ����� ������� movingplatform
		{

			if ((p.dy > 0) || (p.onGround == false))//��� ���� ����� ��������� � ��������� ����� ������, �.� ������ ����
				if (p.y + p.h < movePlatform2.y + movePlatform2.h)//���� ����� ��������� ���� ���������
				{
					p.y = movePlatform2.y - p.h + 3; p.x += movePlatform2.dx*time; p.dy = 0; p.onGround = true; // �� ����������� ������ ���, ����� �� ��� �� ����� �� ���������
				}
		}

		if (easyEnemy.getRect().intersects(p.getRect()))//���� ������������� ������� ������� ������������ � �������
		{
			if (easyEnemy.name == "EasyEnemy") {//� ��� ���� ��� ������� EasyEnemy,��..
				if (p.dx <= 0) { p.x = easyEnemy.x + easyEnemy.w; }//���� ����������� � ������ � ����� ���� ����� �� ����������� ������
				if (p.dx >= 0) { p.x = easyEnemy.x - p.w; }//���� ����������� � ������ � ����� ���� ������ �� ����������� ������
			}
		}
		

		if (jumpImage.getRect().intersects(p.getRect()) || jumpImage2.getRect().intersects(p.getRect()))//���� ������������� ������� ������� ������������ � �������
		{
			if (jumpImage.name == "jumpImage" || jumpImage2.name == "jumpImage") {//� ��� ���� ��� ������� jumpImage,��..

				if ((p.dy > 0) && (p.onGround == false)) {//���� �������� �� �����,�� ���� ����� �������� 0,����������� �� ���� ���� �����,���� ��� �������� 0
					p.dy = -1;
				}
			}
		}


		if (Keyboard::isKeyPressed(Keyboard::Tab)) { return true; }
		if (Keyboard::isKeyPressed(Keyboard::Escape)) { return false; }

		p.update(time);
		jumpImage.updateJump(time);
		jumpImage2.updateJump(time);
		movePlatform2.update(time);
		movePlatform.update(time);
		easyEnemy.update(time);
		window.setView(view);
		window.clear();
		for (int i = 0; i < HEIGHT_MAP; i++)
			for (int j = 0; j < WIDTH_MAP; j++)
			{
				if (TileMap[i][j] == ' ')  s_map.setTextureRect(IntRect(0, 0, 32, 32));
				if (TileMap[i][j] == 'm')  s_map.setTextureRect(IntRect(32, 0, 32, 32));
				if ((TileMap[i][j] == 'f')) s_map.setTextureRect(IntRect(96, 0, 32, 32));
				if ((TileMap[i][j] == 'h')) s_map.setTextureRect(IntRect(128, 0, 32, 32));
				if ((TileMap[i][j] == 'a')) s_map.setTextureRect(IntRect(192, 0, 32, 32));
				if ((TileMap[i][j] == 'e')) s_map.setTextureRect(IntRect(224, 0, 32, 32));
				if ((TileMap[i][j] == 'b')) s_map.setTextureRect(IntRect(320, 0, 32, 32));
				if ((TileMap[i][j] == '0')) s_map.setTextureRect(IntRect(352, 0, 32, 32));
				if ((TileMap[i][j] == 'd')) s_map.setTextureRect(IntRect(448, 0, 32, 32));

				s_map.setPosition(j * 32, i * 32);
				window.draw(s_map);
			}

		ostringstream playerHealthString, gameTimeString, playerScoreString;
		playerHealthString << p.health; gameTimeString << gameTime;	playerScoreString << p.playerScore;
		text.setString("Health: " + playerHealthString.str() + "\nGame time: " + gameTimeString.str() + "\nCollected money:" + playerScoreString.str());
		text.setPosition(view.getCenter().x - 640, view.getCenter().y - 360);
		if (p.life <= 0) {
			text2.setString("YOU DEAD\n Enter the TAB");
			text2.setPosition(view.getCenter().x - 200, view.getCenter().y - 100);
		}

		if (p.playerScore == 44) { 
			return false;
		}

		window.draw(text);	
		window.draw(text2);
		window.draw(movePlatform.sprite);
		window.draw(movePlatform2.sprite);	
		window.draw(jumpImage.sprite);
		window.draw(jumpImage2.sprite);
		window.draw(easyEnemy.sprite);
		window.draw(p.sprite);
		window.display();
	}
}
void gameRunning() {//�-��� ������������� ���� , ���� ��� ����������
	if (startGame()) { gameRunning(); }////���� startGame() == true, �� �������� ������ �-��� isGameRunning, ������� � ���� ������� ����� �������� startGame() 
}

int main()
{
	gameRunning();
	return 0;
}