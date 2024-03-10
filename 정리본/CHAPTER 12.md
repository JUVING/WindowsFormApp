
c#은 대분분의 그래픽 기능을 위해 System.Drawing 네임스페이스에 포함되어 있는 Graphic(System.Drawing.Graphics) 클래스를 제공한다.

# *그래픽 개체*
생성하는 방법
1. Paint 이벤트 처리기의 매개변수
2. CreateGraphics() 메소드
3. Graphics.FormImage() 메소드


# *CreateGraphics() 메소드*
- Paint 이벤트 처리기에서는 매개변수를 통하여 그래픽 객체를 얻었지만 다른 이벤트 처리기나 메소드 내에서 그리기를 하고자 할 때에는 새로운 그래픽 객체를 생성해야만한다.
- 그런 경우 Control클래스의 CreateGraphics() 메소드를 사용하여 그래픽 객체를 생성할 수 있다.


# *Graphics.FromImage() 메소드*
- 그래픽 객체는 이미지에서 만들러졌기 때문에 그리기 작업의 결과가 화면에 곧바로 나타나지 않는다.
- 왜냐하면 이미지 객체에 직접 그리기 작업을 했기 때문이다.
- 결과를 화면에 표시하려면 이미지 객체를 화면에 출력해야한다.
- 게임과 같은 프로그램에서 많이 사용한다 그 이유는 그려지는 과정을 사용자가 부자연스럽게 느껴지기 때문에 그래서 Graphics.FromImage()를 사용하여 완성된 최종 이미지를 화면에 한번 표시하기 때문이다.


# *Point 구조체*
- 평면상의 한 점을 표시하기 위한 자료형이 Point 구조체이며 x 좌표 y좌표의 형식으로 위치를  표시한다.

Point 구조체의 프로퍼티
![[Pasted image 20240310014929.png]]

- Point 구조체와 비슷한 의미를 가지는 구조체로 PointF 구조체가 있다.
	- Point 구조체는 x와 y 값을 표현하지만 PointF 구조체는 실수를 사용하여 표현
	- PointF 구조체는 Point구조체 보다 정밀한 위치를 나타낼 수 있다.


PointF를 Point로 변환하는 방법
![[Pasted image 20240310014339.png]]

# *Size 구조체*
- 사각형 모양을 갖는 영역의 크기를 나타내기 위해서 사용되는 구조체이다.
- 영역의 크기는 폭(width) 높이(height)로 나타낸다.
- 그리기뿐만 아니라 폼이나 컨트롤에서 사각형 모양으로 표시되는 영역의 크기를 나타낼 때도 사용된다.

Size area = new Size(); //주어진 매개변수가 없으면 폭, 높이는 0을 나타낸다.
Size area = new Size(width, height); // 첫 번째 매개변수 폭 두 번째 매개변수는 높이인 사각형을 의미한다.

size 구조체의 프로퍼티
![[Pasted image 20240310015017.png]]

SizeF 구조체는 실수를 사용하여 표현하면 Size 보다 정밀하게 영역을 표현할 수 있다.

SIzeF를 SIze로 변환하는 방법
![[Pasted image 20240310020931.png]]


# *Rectangle 구조체*
- 사각형 모양을 갖는 영역의 위치와 크기를 나타내기 위해서 사용된다.
- Point 구조체와 Size 구조체의 개념을 모두 가지고 있는 구조체이다.
- Rectangle 구조체는 사각형이나 또는 폼과 컨트롤의 위치와 크기를 동시에 나타내기 위해서 사용된다.

Rectangle r = new Rectangle();
Rectangle r = new Rectangle(Point, Size);
Rectangle r = new Rectangle(X, Y, width, height);

Rectangle 구조체의 프로퍼티
![[Pasted image 20240310020638.png]]
- Rectangle 구조체와 비슷한 의미를 가지는 구조체로 RectangleF 구조체가 있다.
- RectangleF 구조체는 Rectangle 구조체 보다 정밀한 영역의 위치와 크기를 표현한다.

RectangleF를 Rectangle로 변환하는 방법
![[Pasted image 20240310021116.png]]


Rectangle 구조체의 메소드
![[Pasted image 20240310021604.png]]


# *Color 구조체*
- 하나의 색을 RGB형식으로 나타내는 구조체이다.
- color 구조체는 빛의 삼원색인 레드, 그린, 블루의 값을 가지면 각각 0~255 사이의 값으로 표현된다.

Color c = Color.FromArgb(R, G, B);
Color c = Color.FromArgb(A, R, G, B); //A는 투명도를 나타낸다.
Color c = Color.FromArgb(KnownColor.Member); //이미 알려진 생삭의 목록을 나타낸다
Color c = Color.FromArgb("ColorName");

*KnownColor열거형
- 이미 알려진 생삭의 목록을 나타내며 시스템 색상인지 아닌지에 따라 두 가지로 분류된다. 시스템 색상은 윈도우 환경에 따라 색상 값이 바뀔 수 있느나 시스템 색상이 아닌 경우는 색상 값이 고정되어 있다.

*시스템 색상인지 아닌지 알아내는 법*
public bool IsKnownColor{get;}
public bool IsNameColor{get;}
public bool IsSystemColor{get;}

Color 구조체의 프로퍼티
![[Pasted image 20240310024007.png]]


# *Pen 클래스*
- 직선이나 도형을 그릴 때 색상이나 굵기 등 선에 관한 정보를 갖고 있는 객체가 펜이며 펜을 위한 클래스가 Pen클래스이다.
- 펜은 파일과 같이 운영체제에서 제공하는 자원이므로 사용이 끝난 후에는 Dispose() 메소드를 호출하여 자원을 반환해야 한다.

Pen클래스의 주요 프로퍼티
![[Pasted image 20240310024842.png]]

*width 프로퍼티*
public float width{get; set;}
- 펜의 굵기는 일반적으로 지칭되는 펜의 굵기와 동일한 의미를 지닌다.
- 펜의 굵기가 크면 굵은 선이 작으면 가는 선이 그려진다.

*DashStyle 프로퍼티
- 점선이나 파선처럼 선의 모양을 나타내는 프로퍼티이다.
- DashStyle의 열거형은 System.Drawing.Drawing2D 네임스페이스에 속해있다.

*StartCap/EndCap 프로퍼티
- 선 시작과 끝의 모양을나타내는 프로퍼티이다.
- LineCap 열거형으로 정의되어 있으며 System.Drawing.Drawing2D 네임스페이스에 속해있다.

# *Brush 클래스*
- 도형과 같이 일정한 면적을 차지하는 부분을 색이나 모양 패턴, 혹은 그림으로 채울 때 사용하는 객체가 브러시이다.
- 브러시도 펜과 마찬가지로 운영체제에서 제공하는 자원이므로 끝난 후에 Dispose() 호출해야한다.

Brush 클래스의 파생 클래스
![[Pasted image 20240310031746.png]]


# *Font 클래스*
- 문자열을 그릴 때 사용하는 글꼴의 모양과 크기를 나타내는 클래스이다.
- Font도 마찬가지로 운영체제가 제공하는 자원이므로 해제해야한다.
- 첫 번째 매개변수는 서채의 이름, 두 번째 매개변수는 글자 크기, 세 번째 매개변수는글꼴 모양을 나타낸다.

FontStyle 열거형 상수
![[Pasted image 20240310032325.png]]

Font 클래스의 주요 프로퍼티
![[Pasted image 20240310032635.png]]


# *Image 클래스*
- 이미지를 표현하는 방법은 특성에 따라 래스터 기반 이미지와 벡터 기반 이미지로 구분할 수 있다.
- 복잡하고 일전한 형태를 가지지 않은 이미지를 표현하기 좋다.

Image 클래스의 주요 프로퍼티
![[Pasted image 20240310033105.png]]

# *Bitmap 클래스*
- Image 클래스에서 파생된 클래스로 래스터 기반 이미지를 나타내는 클래스이다.
- 래스터 이미지 파일뿐만 아니라 메모리에서만 존재하는 가상의 이미지를 나타낼 때도 사용할 수 있다.

Bitmap 클래스에서 지원하는 파일 형식
![[Pasted image 20240311025819.png]]


# *Metafile 클래스*
- Image 클래스에서 파생된 클래스로 벡터 기반 이미지를 나타내는 클래스이다.
- System.Drawing.Imaging 네임스페이스에 포함되어 있다.
