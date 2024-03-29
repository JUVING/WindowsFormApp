
# *대화상자 : 
- 사용자와 애플리케이션 사이에 정보를 주고받을 수 있는 교량적인 역할을 담당한다.
- 사용자와 프로그램 사이에 주로 소량의 데이터를 주고 받기위한 수단으로 사용된다.
- 대화상자를 생성하는 방법에는 모달 또는 모덜리스라는 두 가지가 있다.
- 모달 대화상자란 대화상자가 종료되기 전에 대화상자를 띄운 애플리케이션으로 돌아갈 수 없는 대화상자를 의미한다.
- 모달리스 대화상자가 종료되지 않더라도 대화상자를 띄운 애플리케이션으로 돌아갈 수 있는 대화상자를 의미한다.


# *모달 대화상자*
대화상자가 종료되기 전에 대화상자를 띄운 애플리케이션으로 돌아갈 수 없는 대화상자를 의미한다.
1. 대화상자의 작업이 끝나지 않으면 사용자 상호작용이 더 이상 진행하지 못하도록 구현할 때 사용하는 방법
2. 모달 대화상자 종류는 애플리케이션 모달 대화상자, 시스템 모달 대화상자로 나뉜다.
3. 대화상자를 띄운 애플리케이션으로 돌아가지 못 하지만 다른 애플리케이션으로 돌아갈 수 있는 대화상자이다.

# *모덜리스 대화상자*
- 현재 대화상자의 요구에 반응하지 않아도 다른 대화상자로의 전환이 가능한 대화상자를 말한다.
- show()메소드를 사용하면 되는 것이다.


# *메시지 상자*
- 간단한 텍스트 정보와 다양한 종류의 버튼 및 특정한 아이콘을 함께 구성할 수 있는 상자로서 애플리케이션의 실행 중 간단한 메시지를 프로프트 형식으로 제공하고자 할 때 주로 사용한다.

생성 예시
1. MessageBox.Show(message);
2. MessageBox.Show(message, caption);
3. MessageBox.Show(message, caption, buttonkind);
4. MessageBox.Show(message, caption, buttonkind, iconkind);
- message : 표시 하고자하는 문자열
- caption : 캡션 문자열로 제목 표시줄을 표실할 문자열
- buttonkind : 메시지 상자에 포함될 버튼의 종류
- iconkind : 메시지 상자에 표시될 아이콘


*메시지 상자의 버튼

MessageBoxButton 열거형
![[Pasted image 20240304032518.png]]


*메시지 상자의 아이콘*
MessageBoxIcon열거형
![[Pasted image 20240304033924.png]]

*기본 버튼 설정*
- 메시지 박스에 2개 이상 버튼이 포함되어 있다면 기본 버튼을 설정할 수 있다
- 기본 버튼이란 초기에 입력 퍼커스를 갖는 버튼을 의미하며 디폴트로 선택되는 버튼이다.
- 기본 버튼을 지정하는 방법은 Show() 메소드의 5번째 매개변수에 명시하는 것이다.
	- ex) show(p1, p2, p3, p4, MessageBoxDefaultButton);
- 기본 버튼 지정에 사용하는 기호 상수는 MessageBoxDefaultButton 열거형에 정의되어 있다.
- 명시되어 있지 않으면 첫 번째 버튼이 입력 포커스를 가진다.


# *공통 대화상자*
- 윈도우 운영체제는 애플리케이션에서 자주 사용하는 대화상자를 기본적으로 제공한다.
- 윈도우 운영체제가 내부적으로 사용하고 있을 뿐만 아니하 애플리케이션의 요청이 있을 경우 원하는 대화상자를 제공해 준다.
- 윈도우 운영체제가 제공하는 공통 대화상자에는열기, 다른 이름으로 저장, 글꼴, 색, 인쇄, 페이지 설정 등 6가지가 있다.

*열기 대화상자*
- 사용자가 드라이브, 폴더, 파일 확장자를 설정하여 원하는 형식의 파일을 찾을 수 있는 기능을 제공하는 대화상자이다.
- OpenFileDialog 컴포넌트를 폼에 추가해야 한다.

OpenFileDialog 컴포넌트의 프로퍼티
![[Pasted image 20240304044003.png]]


# *글꼴 대화상자*
- 사용자가 글꼴, 글자의 크기, 글자의 생삭, 형태 등을 선택할 수 있는 기능을 제공하는 대화상자이다.
- FontDialog 컴포넌트를 추가해야 한다.

FontDialog 컴포넌트의 프로퍼티
![[Pasted image 20240305013325.png]]


# *색 대화상자*
- 사용자가 색상표에서 색을 선택하거나 사용자 색을 생성하여 사용할 수 있는 기능을 제공하는 대화상자이다.
- ColorDialog 컴포넌트를 폼에 추가해야 한다.


# *인쇄 대화상자*
- 사용자가 인쇄할 프린터와 인쇄 범위, 인쇄 매수 등을 선택할 수 있는 기능을 제공

과정
1. PrintDialog 컴포넌트 폼에 추가
2. PrintDialog 컴포넌트의 프로퍼티 중 PrinterSetting와 PrintDocument 프로퍼티를 
   설정
3. PrintDocument 클래스를 사용하기 위해서는 System.Drawing.Printing 네이스페이스를 using해야한다.
