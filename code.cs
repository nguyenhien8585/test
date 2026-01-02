
new TikzItem2
{
    Id = 1,
    Title = "Đồ thị kết hợp hàm bậc ba và hàm phân thức",
    Category = "Phức tạp",
    Description = "Đồ thị gồm hàm bậc ba y=-x³+3x trên [-√2, √2] và hàm phân thức y=2/x ở hai nhánh ngoài, có điểm cực trị tại (±1, ±2).",
    ImagePath = "Phuc_tap/phuctap1.png",
    Code = @"\begin{tikzpicture}[>=stealth,x=1cm,y=1cm,scale=.7] 
\draw[->] (-5,0) -- (5,0) node[below] {\small $x$};
\draw[->] (0,-3) -- (0,3) node[right] {\small $y$};
\foreach \x in {1}
\draw[thin,shift={(\x,0)}] (0pt,2pt)--(0pt,-2pt)node[below] {\footnotesize $\x$};
\foreach \x in {-1}
\draw[thin,shift={(\x,0)}] (0pt,2pt)--(0pt,-2pt)node[above] {\footnotesize $\x$};
\foreach \y in {-2,-1}
\draw[thin,shift={(0,\y)}] (2pt,0pt)--(-2pt,0pt)node[right] {\footnotesize $\y$};
\foreach \y in {1,2}
\draw[thin,shift={(0,\y)}] (2pt,0pt)--(-2pt,0pt)node[left] {\footnotesize $\y$};
\draw [fill=white,draw=black] (0,0) circle (1pt)node[above left] {\footnotesize $O$};
\clip(-5,-3) rectangle (5,3);
\draw[thick,smooth,samples=100,domain=-sqrt(2):sqrt(2)] plot(\x,{-(\x)^3+3*(\x)});
\draw[thick,smooth,samples=100,domain=-5:-sqrt(2)] plot(\x,{2/(\x)});
\draw[thick,smooth,samples=100,domain=sqrt(2):5] plot(\x,{2/(\x)});
\draw[dashed] (-1,0)--(-1,-2)--(0,-2) (1,0)--(1,2)--(0,2);
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 2,
    Title = "Đồ thị hàm Gauss với hình chữ nhật nội tiếp",
    Category = "Phức tạp",
    Description = "Đồ thị hàm phân phối chuẩn y=e^(-2x²) với hình chữ nhật ABCD nội tiếp, minh họa bài toán tối ưu diện tích.",
    ImagePath = "Phuc_tap/phuctap2.png",
    Code = @"\begin{tikzpicture}[smooth,samples=300,scale=1.3,>=stealth]
\draw[->] (-1.8,0)--(1.8,0) node[below]{\footnotesize $x$};
\draw[->] (0,-0.4)--(0,1.5) node[right]{\footnotesize $y$};
\draw (0,0) node[below left]{\footnotesize $O$};
\draw[thick,color=blue,domain=-1.5:1.5] plot(\x,{e^(-2*(\x)^2)});
\draw[fill=violet] (-0.6,0) circle(0.7pt) (0.6,0) circle(0.7pt) (-0.6,0.487) circle(0.7pt) (0.6,0.487) circle(0.7pt);
\draw[] (-0.6,0)node[below left]{\footnotesize$D$}--(-0.6,0.487)node[above left]{\footnotesize$A$}--(0.6,0.487)node[above right]{\footnotesize$B$}--(0.6,0)node[below right]{\footnotesize$C$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 3,
    Title = "Đồ thị hàm số đi qua 4 điểm đặc biệt",
    Category = "Phức tạp",
    Description = "Đồ thị hàm số trơn đi qua các điểm (-1,-4), (0,-4), (1,-3), (2,-2), minh họa hàm số có nhiều điểm uốn.",
    ImagePath = "Phuc_tap/phuctap3.png",
    Code = @"\begin{tikzpicture}[scale=0.8, font=\footnotesize, line join=round, line cap=round,>=stealth]
\def \xmin{-3}
\def \xmax{3}
\def \ymin{-5.5}
\def \ymax{1}
\draw[->] (\xmin,0)--(\xmax,0) node[below left] {$x$};
\draw[->] (0,\ymin)--(0,\ymax) node[below left] {$y$};
\draw (0,0) node [below right] {$O$};
\foreach \x in {-1,1,2}
\draw[thin] (\x,1pt)--(\x,-1pt) node [above] {$\x$};
\foreach \y in {-3,-2}
\draw[thin] (1pt,\y)--(-1pt,\y) node [left] {$\y$};
\draw[thin] (1pt,-4)--(-1pt,-4) node [below left] {$-4$};
%%Vẽ thêm mấy cái râu ria
\draw[dashed,thin](-1,0)--(-1,-4)--(0,-4);
\draw[dashed,thin](1,0)--(1,-3)--(0,-3);
\draw[dashed,thin](2,0)--(2,-2)--(0,-2);
\coordinate (A) at (-1.64,-5);
\coordinate (B) at (-1,-4);
\coordinate (C) at (0,-4);
\coordinate (D) at (1,-3);
\coordinate (E) at (2,-2);
\coordinate (F) at (3,-5);
\draw
(A) .. controls +(90:0.1) and +(180:0.1) ..
(B) .. controls +(50:.2) and +(180:.2) ..
(C) .. controls +(0:.55) and +(60:.5) ..
(D) .. controls +(60:.5) and +(180:.4) .. 
(E) .. controls +(0:.9) and +(-90:.6).. (F);
%\tkzLabelPoints(A,B,C,D,E,F)
\tkzDrawPoints[fill=black](B,C,D,E)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 4,
    Title = "Đồ thị hàm số dạng chữ W đối xứng",
    Category = "Phức tạp",
    Description = "Đồ thị hàm số đối xứng qua trục y, có hai điểm cực tiểu (-2,-4) và (2,-4), đi qua gốc tọa độ.",
    ImagePath = "Phuc_tap/phuctap4.png",
    Code = @"\begin{tikzpicture}[scale=0.8, font=\footnotesize, line join=round, line cap=round, >=stealth]
\draw[->] (-3,0)--(3,0)node[below left]{$x$};
\draw[->] (0,-5)--(0,1.5)node[left]{$y$};
\draw[dashed] (-2,0)node[above]{$-2$}--(-2,-4)--(0,-4)node[below left]{$-4$}--(2,-4)--(2,0)node[above]{$2$} (0,0)node[above left]{$O$};
\draw (-2.5,1)..controls+(0:0)and+(180:0.2)..(-2,-4)
..controls+(0:0.3)and+(180:0.3)..(0,0)
..controls+(0:0.3)and+(180:0.3)..(2,-4)
..controls+(0:0.3)and+(180:0)..(2.5,1);
\foreach \diemx/\diemy in {0/0,-2/0,-2/-4,2/-4}{\fill (\diemx,\diemy)circle(1pt);}
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 5,
    Title = "Đồ thị hàm số có 4 điểm đặc biệt liên tiếp",
    Category = "Phức tạp",
    Description = "Đồ thị hàm số đi qua các điểm (-1,1), (0,0), (1,-1), (2,-2) với dạng dao động phức tạp.",
    ImagePath = "Phuc_tap/phuctap5.png",
    Code = @"\begin{tikzpicture}[>=stealth,scale=0.8, line join=round, line cap=round]
\draw[->] (-2,0)--(4,0) node [below]{$x$};
\draw[->] (0,-3.5)--(0,2.5) node [left]{$y$};
\node at (0,0) [below left]{$O$};
\draw[dashed] (-1,0) node[above left] {$-1$} -- (-1,1) -- (0,1)node[right] {$1$};
\draw[dashed] (1,0) node[above] {$1$} -- (1,-1) -- (0,-1)node[below right] {$-1$};
\draw[dashed] (2,0) node[above] {$2$} -- (2,-2) -- (0,-2)node[below right] {$-2$};
\draw plot[smooth,tension=0.7] coordinates{(-1.04,2) (-0.7,-3.1) (0.04,0.05) (1,-1) (1.6,-1.3) (2.2,-1.81) (2.5,2)};
\draw[fill=black] (-1,1) circle (1.5pt);
\draw[fill=black] (0,0) circle (1.5pt);
\draw[fill=black] (1,-1) circle (1.5pt);
\draw[fill=black] (2,-2) circle (1.5pt);
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 6,
    Title = "Đồ thị hàm số với nhiều điểm cực trị",
    Category = "Phức tạp",
    Description = "Đồ thị hàm số có 3 điểm cực trị tại x=-1, x=1.5, x=5.5 với giá trị cực đại y=10 và y=13.",
    ImagePath = "Phuc_tap/phuctap6.png",
    Code = @"\begin{tikzpicture}[>=latex,smooth,line cap=round, line join=round, font=\scriptsize,scale=0.33]
\draw[->] (-6,0) -- (11,0)node[below]{$x$};
\draw[->] (0,-2) -- (0,15) node[right]{$y$};
\draw[smooth,thick] 
(-4,-1) ..controls +(85:0.7) and +(-180:1.2)..(-1,10) ..controls +(0:1) and +(-180:1)..(1.5,5)..controls +(0:1) and +(-180:1)..(5.5,13)..controls + (0:1.5) and +(-150:0.01)..(10,-1);
\draw[dashed] (-1,0)node[below]{$-1$} -- (-1,10)--(0,10) node[right]{$10$} (0,5)node[left] {$5$}--(1.5,5)--(1.5,0) node[below]{$1,5$} (0,13)node[left]{$13$} -- (5.5,13) -- (5.5,0)node[below]{$5,5$} (-3.4,0)node[above left]{$-3,4$}(9,0) node[below]{$9$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 7,
    Title = "Hai đồ thị hàm số y=f(x) và y=h(x)",
    Category = "Phức tạp",
    Description = "Đồ thị hàm hữu tỉ y=x/(x+1) có tiệm cận đứng x=-1, tiệm cận ngang y=1 và đồ thị y=h(x) có điểm cực tiểu tại x=-3 và x=1.",
    ImagePath = "Phuc_tap/phuctap7.png",
    Code = @"\begin{tikzpicture}[scale=.71,font=\footnotesize,line join=round, line cap=round,>=stealth]
\draw[->] (-7,0)--(7,0) node[below] {$x$};
\draw[->] (0,-4)--(0,3.5) node[left] {$y$};
\draw[fill=black] (0,0) circle (1pt) node[above left] {$O$};
\begin{scope}
\clip (-7,-4) rectangle (7,3.5);
\draw (-1,-4)--(-1,3.5) (-7,1)--(7,1);
\draw[smooth,samples=100,thick, domain=-7:-1.1] plot (\x, {(\x)/((\x)+1)});
\draw[smooth,samples=100, thick,domain=-0.9:7] plot (\x, {(\x)/((\x)+1)});
\draw
(-6,3) ..controls +(-80:.1) and +(180:.71) ..
(-3,-2) ..controls +(0:.51) and +(180:.51)..
(-1,0) ..controls +(0:.51) and +(180:.51)..
(1,-2) ..controls +(0:.51) and +(180:.01)..
(3,2) node[right] {$y=h(x)$}
;
\end{scope}
\draw (-1,0) node[above left] {$-1$}
(-3,0) node[above] {$-3$}
(1,0) node[shift=(65:2.5mm)] {$1$}
(0,1) node[above left] {$1$};
;
\draw[dashed] (-3,0)--(-3,-2) (1,0)--(1,-2);
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 8,
    Title = "Đồ thị hàm số có 4 điểm đặc biệt",
    Category = "Phức tạp",
    Description = "Đồ thị y=f(x) đi qua các điểm (-2,1), (-1,3), (1,0), (3,5) với dạng dao động liên tục.",
    ImagePath = "Phuc_tap/phuctap8.png",
    Code = @"\begin{tikzpicture}[smooth,samples=300,scale=0.7,>=stealth,font=\footnotesize]
\draw[->] (-4,0)--(7,0) node[below]{$x$};
\draw[->] (0,-2)--(0,6) node[right]{$y$};
\draw (0,0) node[below left]{$O$};
\draw[thick] plot[smooth,tension=0.85] coordinates{(-3.1,4) (-2.05,1.03) (-0.9,3) (1.2,0.045) (3.1,5) (5,-1.5)}node[below right]{$y=f(x)$};
\draw[fill=black] (-2,1) circle(1.5pt) (-1,3) circle(1.5pt) (1,0) circle(1.5pt) (3,5) circle(1.5pt) (0,1) circle(1pt) (0,3) circle(1pt) (0,5) circle(1pt);
\draw[dashed] (-2,0)node[below]{$-2$}--(-2,1)--(0,1)node[below left]{$1$} (-1,0)--(-1,3)--(0,3)node[right]{$3$} (3,0)node[below]{$3$}--(3,5)--(0,5)node[left]{$5$} ;
%\node[right] at (2,2.4) {$2$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 9,
    Title = "Hai đồ thị đối xứng y=f(x) và y=-f(x)",
    Category = "Phức tạp",
    Description = "Đồ thị hàm số y=f(x) và y=-f(x) đối xứng qua trục hoành, với đường thẳng y=√(m²-1) cắt cả hai đồ thị.",
    ImagePath = "Phuc_tap/phuctap9.png",
    Code = @"\begin{tikzpicture}[smooth,samples=300,scale=0.7,y=0.7cm,>=stealth,font=\footnotesize]
\draw[->] (-4,0)--(7,0) node[below]{$x$};
\draw[->] (0,-7)--(0,7) node[right]{$y$};
\draw (0,0) node[below left]{$O$};
\draw[thick] plot[smooth,tension=0.85] coordinates{(-3.2,7) (-2.2,1.15) (-0.9,3) (1.2,0.045) (3.35,4.75) (5.6,-7)}node[below right]{$y=f(x)$};
\draw[thick] plot[smooth,tension=0.85] coordinates{(-3.2,-7) (-2.2,-1.15) (-0.9,-3) (1.2,-0.045) (3.35,-4.75) (5.6,7)}node[below right]{$y=-f(x)$};
\draw (-4,-4)--(6,-4) node[below right]{$y=\sqrt{m^2-1}$};
\draw[fill=black] (-2,1) circle(1.5pt) (-1,3) circle(1.5pt) (1,0) circle(1.5pt) (3,5) circle(1.5pt) (0,1) circle(1pt) (0,3) circle(1pt) (0,5) circle(1pt);
\draw[dashed] (-2,0)--(-2,1)--(0,1)node[below left]{$1$} (-1,0)--(-1,3)--(0,3)node[right]{$3$} (3,0)--(3,5)--(0,5)node[left]{$5$} ;
\draw[fill=black] (-2,-1) circle(1.5pt) (-1,-3) circle(1.5pt) (1,0) circle(1.5pt) (3,-5) circle(1.5pt) (0,1) circle(1pt) (0,3) circle(1pt) (0,5) circle(1pt);
\draw[dashed] (-2,0)--(-2,-1)--(0,-1)node[below right]{$-1$} (-1,0)--(-1,-3)--(0,-3)node[right]{$-3$} (3,0)--(3,-5)--(0,-5)node[left]{$-5$} ;
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 10,
    Title = "Đồ thị hàm số có đường thẳng ngang cắt",
    Category = "Phức tạp",
    Description = "Đồ thị hàm số với đường thẳng ngang y=-0.9 cắt đồ thị tại hai điểm x≈1 và x≈2.",
    ImagePath = "Phuc_tap/phuctap10.png",
    Code = @"\begin{tikzpicture}[>=stealth,line join=round,line cap=round,font=\footnotesize,scale=.8]
\path (2.8,0.2)coordinate[label=center:$x$](x) (0.2,1.8)coordinate[label=center:$y$](y) (-.4,-.7)coordinate[label=center:$-1$](-1)
(-.3,.3)coordinate[label=center:$O$](O)
(.8,.3)coordinate[label=center:$1$](1) (1.8,.3)coordinate[label=center:$2$](2);
\draw [->] (-2,0)--(3,0);
\draw [->] (0,-3)--(0,2);
\draw (-2,-.9)--(3,-.9);
\draw [dashed] (.8,0)--(.8,-.9);
\draw [dashed] (1.75,0)--(1.75,-.9);
\draw[thick] plot[smooth,tension=.65] coordinates{(-.7,-3) (-.1,-1) (0.5,-1.2) (1.5,-0.5) (2.3,-3)};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 11,
    Title = "Đồ thị hàm số có 3 điểm cực trị",
    Category = "Phức tạp",
    Description = "Đồ thị hàm số đi qua các điểm cực trị tại x=-4, x=-2, x=3 với biên độ dao động lớn.",
    ImagePath = "Phuc_tap/phuctap11.png",
    Code = @"\begin{tikzpicture}[scale=.61, font=\footnotesize,x=0.8cm,line join=round, line cap=round,>=stealth]
\draw[->] (-7,0)--(7,0) node[below] {$x$};
\draw[->] (0,-4)--(0,3.5) node[left] {$y$};
\draw[fill=black] (0,0) circle (1pt) node[above right] {$O$};
\path
(-6,2.5) coordinate (A)
(-4,-2) coordinate (B)
(-2,1) coordinate (C)
(3,-3.5) coordinate (D)
(6,2.5) coordinate (E)
;
\draw
(A) .. controls +(-80:.1) and +(180:.75)..
(B) .. controls +(0:0.75) and +(180:0.76)..
(C) .. controls +(0:1.2) and +(180:1.5)..
(D) .. controls +(0:1.5) and +(180:.1)..
(E)
;
\draw[dashed] (-4,0)--(B) (-2,0)--(C) (3,0)--(D);
\draw[fill=black] (-4,0) circle (1pt) node[above] {$-4$}
(-2,0) circle (1pt) node[below] {$-2$}
(3,0) circle (1pt) node[above] {$3$}
;
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 12,
    Title = "Đồ thị giá trị tuyệt đối hàm bậc ba",
    Category = "Phức tạp",
    Description = "Đồ thị y=|ax³+bx²+cx+d| với đường thẳng y=4/3, minh họa phương trình chứa giá trị tuyệt đối.",
    ImagePath = "Phuc_tap/phuctap12.png",
    Code = @"\begin{tikzpicture}[scale=0.7, font=\footnotesize, line join=round, line cap=round,>=stealth]
\def\a{0.2} \def\b{-0.8} \def\c{-0.8} \def\d{3.2} % Hệ số
\def\xmin{-3} \def\xmax{5}
\def\ymin{-1} \def\ymax{4} 
%\draw[color=gray!50,dashed] (\xmin,\ymin) grid (\xmax,\ymax); 
\draw[->] (\xmin,0)--(\xmax,0) node [below]{$x$};
\draw[->] (0,\ymin)--(0,\ymax) node [left]{$y$};
\node at (0,0) [below left]{$O$};
\clip (\xmin+0.1,\ymin+0.1) rectangle (\xmax-0.1,\ymax-0.1);
\draw[smooth,samples=300] plot(\x,{abs(\a*(\x)^3+\b*(\x)^2+\c*(\x)+\d)});
\draw[domain=-2.4:4.6, samples=100] plot (\x,{(4/3});
\fill (0,0) circle (1.0pt) (-2,0) circle (1.0pt)node[below]{$-2$} (0,2) circle (1.0pt)node[left]{$2$} (2,0) circle (1.0pt)node[below]{$2$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 13,
    Title = "Đồ thị hàm đạo hàm y=f'(x)",
    Category = "Phức tạp",
    Description = "Đồ thị hàm đạo hàm y=f'(x) dạng dao động, cắt trục hoành tại nhiều điểm, dùng để xét tính đơn điệu của f(x).",
    ImagePath = "Phuc_tap/phuctap13.png",
    Code = @"\begin{tikzpicture}[>=stealth, font=\footnotesize, scale=0.8]
\draw[->] (-4,0)--(3,0) node[below] {$x$};
\draw[->] (0,-1.4)--(0,3.5) node[left] {$y$};
\draw[fill=black] (0,0) node[below right=-0.1] {$O$} circle (1.2pt);
\draw 
(-3,3) .. controls +(82:0.6) and +(180:0.5) .. 
(-2.5,-1) .. controls +(0:0.4) and +(180:0.5) .. 
(-1.5,1) .. controls +(0:0.4) and +(180:0.4) .. 
(-0.5,-0.5) .. controls +(0:0.5) and +(-96:0.5).. (0.5,3) node[right] {$y=f'(x)$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 14,
    Title = "Đồ thị y=f'(t) và y=1/√t",
    Category = "Phức tạp",
    Description = "Hai đồ thị hàm đạo hàm y=f'(t) và hàm y=1/√t trên cùng hệ trục, minh họa bài toán so sánh hàm số.",
    ImagePath = "Phuc_tap/phuctap14.png",
    Code = @"\begin{tikzpicture}[>=stealth, font=\footnotesize, scale=0.8]
\draw[->] (-4,0)--(3,0) node[below] {$t$};
\draw[->] (0,-1.4)--(0,3.5) node[left] {$y$};
\draw[fill=black] (0,0) node[below right=-0.1] {$O$} circle (1.2pt);
\draw 
(-3,3) .. controls +(82:0.6) and +(180:0.5) .. 
(-2.5,-1) .. controls +(0:0.4) and +(180:0.5) .. 
(-1.5,1) .. controls +(0:0.4) and +(180:0.4) .. 
(-0.5,-0.5) .. controls +(0:0.5) and +(-96:0.5).. (0.5,3) node[right] {$y=f'(t)$};
\draw[thick,smooth,samples=100,domain=0.11:2.4] plot(\x,{1/(sqrt(\x))}) node[above] {$y=\dfrac{1}{\sqrt{t}}$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 15,
    Title = "Đồ thị hàm số với 6 điểm đặc biệt",
    Category = "Phức tạp",
    Description = "Đồ thị y=f(x) đi qua các điểm (-11/4, 3/4), (-2,2), (-1,3/4), (3/4,4), (3,3), (15/4,4) với nhiều điểm cực trị.",
    ImagePath = "Phuc_tap/phuctap15.png",
    Code = @"\begin{tikzpicture}[smooth,samples=300,scale=0.8,>=stealth,font=\scriptsize]
\draw[->] (-4,0)--(4.5,0) node[below]{$x$};
\draw[->] (0,-1.5)--(0,5) node[right]{$y$};
\draw (0,0) node[below left]{$O$};
\draw[blue,thick] plot[smooth,tension=0.85] coordinates{(-3.3,-1.13) (-2.1,1.95) (-0.8,0.82) (0.55,3.95) (2.3,2.56) (4.1,4.6)}node[above]{$y=f(x)$};
\draw[fill=black] (-2.75,0.75) circle(1.5pt) (-2,2) circle(1.5pt) (0,3) circle(1.5pt) (0.75,4) circle(1.5pt) (3,3) circle(1.5pt) (3.75,4) circle(1.5pt) (-1,0.75) circle(1.5pt);
\draw[dashed] (-2.75,0)node[below]{$-\frac{11}{4}$}--(-2.75,0.75)--(0,0.75)node[right]{$\frac{3}{4}$}
(-2,0)node[below]{$-2$}--(-2,2)--(0,2)node[right]{$2$}
(-1,0)node[below]{$-1$}--(-1,0.75)
(0.75,0)node[below]{$\frac{3}{4}$}--(0.75,4)--(0,4)node[left]{$4$}
(3,0)node[below]{$3$}--(3,3)--(0,3)node[left]{$3$}
(3.75,0)node[below]{$\frac{15}{4}$}--(3.75,4)--(0.75,4);
;
%\node[right] at (2,2.4) {$2$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 16,
    Title = "Đồ thị hàm số liên tục từng khúc tại x=1",
    Category = "Phức tạp",
    Description = "Đồ thị hàm đa thức từng khúc có nghiệm x=-2, x=1 (kép), x=3 (kép), liên tục tại x=1.",
    ImagePath = "Phuc_tap/phuctap16.png",
    Code = @"\begin{tikzpicture}[thick,>=stealth,scale=0.8]
\draw[->] (-3,0)--(4,0) node[below] {$x$};
\draw[->] (0,-2)--(0,3) node[left] {$y$};
\draw (0,0) node[below left]{$O$};
\draw (-2,0) node[above left] {$-2$};
\draw (1,0) node[below right] {$1$};
\draw (3,0) node[below] {$3$};
\clip (-3,-1.7) rectangle (4,3);
\draw[smooth,samples=100,domain=-3:1] plot(\x,{(\x)*((\x) +2)*((\x)-1)});
\draw[smooth,samples=100,domain=1:4] plot(\x,{((\x)-1)*((\x)-3)*((\x)-3)});
\draw[fill=black] (-2,0) circle(1.5pt) (1,0) circle(1.5pt) (3,0) circle(1.5pt);
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 17,
    Title = "Đồ thị hàm bậc bốn có điểm uốn",
    Category = "Phức tạp",
    Description = "Đồ thị hàm số y=-x⁴+2.2x³-1.6x+1 có điểm uốn tại (x₀, y₀) ≈ (0.45, 0.44).",
    ImagePath = "Phuc_tap/phuctap17.png",
    Code = @"\begin{tikzpicture}[smooth,samples=300,scale=1.1,>=stealth,font=\footnotesize]
\draw[->] (-1.5,0)--(2.5,0) node[below]{$x$};
\draw[->] (0,-0.6)--(0,2) node[right]{$y$};
\draw (0,0) node[below left]{$O$};
\draw[line width=0.7pt,domain=-1:2] plot(\x,{-(\x)^4+2.2*(\x)^3-1.6*(\x)+1})node[below]{$y=f(x)$};
\draw[fill=black] (0.45,0.44) circle(1.5pt);
% (2,0) circle(1.5pt) (0,-1) circle(1.5pt);
\draw[dashed] (0.45,0)node[below]{$x_0$}--(0.45,0.44)--(0,0.44)node[left]{$y_0$};
%\node[right] at (2,2.4) {$2$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 18,
    Title = "Đồ thị hàm số dao động có tiệm cận đứng",
    Category = "Phức tạp",
    Description = "Đồ thị hàm số có tiệm cận đứng x=-3, đi qua điểm (2,2), dao động mạnh với nhiều điểm uốn.",
    ImagePath = "Phuc_tap/phuctap18.png",
    Code = @"\begin{tikzpicture}[smooth,samples=300,scale=0.8,x=0.4cm,y=0.4cm,font=\footnotesize, line join=round, line cap=round, >=stealth]font=\footnotesize, line join=round, line cap=round, >=stealth
\draw[->] (-5,0)--(6.4,0) node[below]{$x$};
\draw[->] (0,-2.5)--(0,9.5) node[right]{$y$};
\draw (0,0) node[below left]{$O$};
\draw[black] plot[smooth,tension=0.85] coordinates{(-4,-2) (-3.2,9.48) (-0.6,2.5) (1.6,2.7) (3.5,-2) (4.77,9)};
\draw[fill=black] (0,2) circle(1pt) (2,2) circle(1pt) (4,0) circle(1pt) (0,0) circle(1pt) (-3,9.5) circle(1pt);
\draw[dashed] (-3,0)node[below]{$-3$}--(-3,9.5)
(2,0)node[below]{$2$}--(2,2)--(0,2)node[left]{$2$};
\node[below] at (4.45,0) {$4$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 19,
    Title = "Đồ thị đạo hàm y=f'(x) từng khúc",
    Category = "Phức tạp",
    Description = "Đồ thị hàm đạo hàm y=f'(x) gồm parabol và parabol ngược, có nghiệm x=0, x=2, x=4.",
    ImagePath = "Phuc_tap/phuctap19.png",
    Code = @"\begin{tikzpicture}[scale=0.9, >=stealth]
\draw[->] (-0.6,0.) -- (5.3,0.);
\draw[->] (0.,-1.7) -- (0.,1.6);
\draw[dashed] (4,0) -- (4,-1.2);
\clip(-0.6,-1.7) rectangle (5.3,1.7);
\draw[smooth,samples=100,domain=0:2] plot(\x,{-0.8*((\x)^2-2*(\x))});
\draw[smooth,samples=100,domain=2:4.5] plot(\x,{0.2*(((\x)-2)*((\x)-7)});
\draw (-0.3,-0.3) node {$O$} (5.2,0.3) node {$x$} (0.35,1.5) node {$y$} (1.9,-0.3) node {$2$} (4.0,0.3) node {$4$} (2.0,1.15) node {$y=f'(x)$};
\fill (0,0) circle(1pt) (2,0) circle(1pt) (4,0) circle(1pt); 
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 20,
    Title = "Đồ thị hàm số trên lưới tọa độ",
    Category = "Phức tạp",
    Description = "Đồ thị hàm số gồm nhiều parabol nối tiếp, đi qua các điểm (-2,-2), (2,2), (4,4) trên lưới tọa độ.",
    ImagePath = "Phuc_tap/phuctap20.png",
    Code = @"\begin{tikzpicture}[thick,>=stealth,scale=.4]
\clip(-3.5,-2.5) rectangle (6.5,7.8);
\draw[ultra thin,color=gray] (-3.5,-2.5) grid (6.5,8.5);
\draw[-> ] (-3,0) -- (6,0)node[below] {\footnotesize $x$};
\draw[-> ] (0,-2.5) -- (0,7.5)node[right=-0.1] {\footnotesize $y$};
\draw(0,0) node[below left=-0.1] {\scriptsize$O$};
\draw[line width=0.8pt] (-2.0,-2) parabola bend (0,6) (0.9,3.5);
\draw[line width=0.8pt] (0.9,3.5) parabola bend (1,3) (1.3,3.1);
\draw[line width=0.8pt] (1.3,3.1) parabola bend (1.6,3.2) (2,2);
\draw[line width=0.8pt] (2,2) parabola bend (2.5,1.5) (4.4,5.5);
\draw (-2,0) node[above left] {\scriptsize $-2$};
\draw (2,0) node[below] {\scriptsize $2$};
\draw (4,0) node[below] {\scriptsize $4$};
\draw (0,-2) node[right] {\scriptsize $-2$};
\draw (0,2) node[left] {\scriptsize $2$};
\draw (0,4) node[left] {\scriptsize $4$};
\draw (0,6) node[above left] {\scriptsize $6$};
\draw[dashed] (0,4) -- (4,4) -- (4,0);
\draw[dashed] (0,2) -- (2,2) -- (2,0);
\draw[dashed] (0,-2) -- (-2,-2) -- (-2,0);
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 21,
    Title = "Đồ thị hàm số và đường thẳng y=x",
    Category = "Phức tạp",
    Description = "Đồ thị hàm số trên lưới với đường thẳng y=x cắt đồ thị, minh họa bài toán tìm giao điểm.",
    ImagePath = "Phuc_tap/phuctap21.png",
    Code = @"\begin{tikzpicture}[thick,>=stealth,scale=.4]
\clip(-3.5,-2.5) rectangle (6.5,8.5);
\draw[ultra thin,color=gray] (-3.5,-2.5) grid (6.5,8.5);
\draw[-> ] (-3,0) -- (6,0)node[above left] {$x$};
\draw[-> ] (0,-2.5) -- (0,8)node[below right] {$y$};
\draw(0,0) node[below right=-0.1] {\scriptsize $O$};
\draw[line width=0.8pt] (-2.0,-2) parabola bend (0,6) (0.9,3.5);
\draw[line width=0.8pt] (0.9,3.5) parabola bend (1,3) (1.3,3.1);
\draw[line width=0.8pt] (1.3,3.1) parabola bend (1.6,3.2) (2,2);
\draw[line width=0.8pt] (2,2) parabola bend (2.5,1.5) (4.4,5.5);
\draw (-2,0) node[above left] {\scriptsize $-2$};
\draw (2,0) node[below] {\scriptsize $2$};
\draw (4,0) node[below] {\scriptsize $4$};
\draw (0,-2) node[right] {\scriptsize $-2$};
\draw (0,2) node[left] {\scriptsize $2$};
\draw (0,4) node[left] {\scriptsize $4$};
\draw (0,6) node[above left] {\scriptsize $6$};
\draw[line width=0.6pt,blue] (-2.5,-2.5) -- (5,5);
\draw[dashed] (0,4) -- (4,4) -- (4,0);
\draw[dashed] (0,2) -- (2,2) -- (2,0);
\draw[dashed] (0,-2) -- (-2,-2) -- (-2,0);
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 22,
    Title = "Đồ thị hàm đạo hàm f'(x) trên đoạn [-2, 4]",
    Category = "Phức tạp",
    Description = "Đồ thị hàm đạo hàm f'(x) có 3 điểm cực trị, dùng để xét tính biến thiên của hàm f(x).",
    ImagePath = "Phuc_tap/phuctap22.png",
    Code = @"\begin{tikzpicture}[>=stealth,x=1.0cm,y=1.0cm,scale=0.7]
% \draw[color=gray,dash pattern =on 1pt off 1pt, xstep=1.0cm,ystep=1.0cm](-2.5,-2.5) grid (4.5,4.5);
\draw[->] (-3,0) -- (5,0) node[below] {$x$};
\draw[->] (0,-1.5) -- (0,3) node[left] {$y$};
\foreach \x in {-2,4}
\draw[shift={(\x,0)},color=black] (0pt,2pt) -- (0pt,-2pt) node[below left] {$\x$};
\foreach \y in {}
\draw[shift={(0,\y)},color=black] (2pt,0pt) -- (-2pt,0pt) node[below left] {$\y$};
\draw (0,0) node[below left] {$O$} (-1.3,2.1) node[above] {$f'(x)$};
\draw plot[smooth,tension=.65] coordinates{(-2,1) (-1.3,2) (0.5,0) (1.7,1.5) (3,-1) (4,2.5)};
\draw[dashed](-2,0)--(-2,1) (4,0)--(4,2.5);
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 23,
    Title = "Đồ thị hàm số có 3 điểm cực trị nổi bật",
    Category = "Phức tạp",
    Description = "Đồ thị hàm số đi qua điểm (2, 4), có 2 điểm cực tiểu và 1 điểm cực đại, dạng dao động mạnh.",
    ImagePath = "Phuc_tap/phuctap23.png",
    Code = @"\begin{tikzpicture}[scale=0.8, font=\footnotesize, y=0.7cm,line join=round, line cap=round, >=stealth]
\draw[->] (-3,0)--(5,0) node[below]{$x$};
\draw[->] (0,-2.5)--(0,6) node[left]{$y$};
\coordinate[label=above left:$O$] (O) at (0,0);
\coordinate (A) at (-2.5,6);
\coordinate (X1) at (-0.6,-1.5);
\coordinate (X2) at (1,5);
\coordinate (X3) at (3,-2);
% \coordinate (X4) at (1.6,1.6);
\coordinate (B) at (4.5,6);
\draw[]
(A) .. controls +(60:0) and +(180:0.9) ..
(X1) .. controls +(0:.9) and +(180:.6) ..
(X2) .. controls +(0:.6) and +(180:.9) ..
(X3) .. controls +(0:.9) and +(180:0) ..
% (X4) .. controls +(30:.05) and +(180:.0001)..
(B);
\fill (0,5)node[left]{$4$}circle(1.2pt) (1,0)node[below]{$2$}circle(1.2pt) (2.2,0)node[above right]{$4$}circle(1.2pt);
\draw[dashed] (0,5)--(1,5)--(1,0);
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 24,
    Title = "Đồ thị hàm số có 4 nghiệm",
    Category = "Phức tạp",
    Description = "Đồ thị hàm số cắt trục hoành tại 4 điểm x=1, x=2, x=5, x=6, dạng sóng liên tục.",
    ImagePath = "Phuc_tap/phuctap24.png",
    Code = @"\begin{tikzpicture}[scale=0.7,line cap=round,line join=round,>=stealth,x=1cm,
y=1cm]
% Vẽ 2 trục, điền các số lên trục
\draw[->] (-1.08,0) -- (9,0); %Vẽ trục Ox
\foreach \x in {} %Đánh số trên trục
\draw[shift={(\x,0)},color=black] (0pt,2pt) -- (0pt,-2pt) 
node[above] { $\x$};
\draw[->,color=black] (0,-2) -- (0,1.98); %Vẽ trục Oy
\foreach \y in {} %đánh số trên trục
\draw[shift={(0,\y)},color=black] (2pt,0pt) -- (-2pt,0pt) 
node[above left] {\normalsize $\y$};
\draw[color=black] (9,.2) node[right] {\normalsize $x$}; %đặt tên trục 
\draw[color=black] (.1,1.8) node[right] {\normalsize $y$}; %đặt tên trục
\draw[color=black] (0pt,-8pt) node[left] {\normalsize $O$}; %gốc tọa độ
\clip(0,-3) rectangle (9.06,2.98); %cắt khung đồ thị
%Vẽ đồ thị
% \draw[smooth,samples=100,domain=0.08:6.5]plot(\x,{-((\x)-1)*((\x)-2)*((\x)-5)*((\x)-6)});
\draw plot[smooth,tension=0.55] coordinates{(0.5,-1) (1,0) (2,1.2) (3,0) (4.5,-1.5) (6,0) (7,0.9) (8,0) (8.5,-1)};
% Vẽ thêm mấy cái râu ria
%Vẽ dấu chấm tròn 
\fill (0cm,0cm) circle (1.5pt); 
\fill (1,0) circle (1.5pt) node[above left] {$1$};
\fill (3,0) circle (1.5pt) node[above right] {$2$};
\fill (6,0) circle (1.5pt) node[above left] {$5$};
\fill (8,0) circle (1.5pt) node[above right] {$6$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 25,
    Title = "Đồ thị hàm số với đường thẳng xiên",
    Category = "Phức tạp",
    Description = "Đồ thị hàm số đi qua các điểm (-4,5), (-3,3), (-1,2), (3,-2) với đường thẳng xiên cắt đồ thị.",
    ImagePath = "Phuc_tap/phuctap25.png",
    Code = @"\begin{tikzpicture}[>=stealth,line join=round,line cap=round,font=\footnotesize,scale=0.7]
\def\xt{-5} \def\xp{6} \def\yd{-3} \def\yt{6}
\draw[->] (\xt,0)--(\xp,0) node[below]{$x$};
\draw[->] (0,\yd)--(0,\yt) node[left]{$y$};
\fill (0,0) circle (1.5pt) node[below left]{$O$};
\begin{scope}
%\clip (\xt+0.1,\yd+0.1) rectangle (\xp-0.1,\yt-0.1);
\foreach \x in {-4,-3,-2,-1}
\draw[thin] (\x,1pt)--(\x,-1pt) node [below] {$\x$};
\foreach \x in {1,2,3,4,5}
\draw[thin] (\x,1pt)--(\x,-1pt) node [above] {$\x$};
\foreach \y in {-2,-1,1}
\draw[thin] (1pt,\y)--(-1pt,\y)node [left] {$\y$};
\foreach \y in {2,3,4,5}
\draw[thin] (1pt,\y)--(-1pt,\y)node [right] {$\y$};
\draw[dashed] (-4,0)--(-4,5)--(0,5) 
(-3,0)--(-3,3)--(0,3)
(-1,0)--(-1,2)--(0,2)
(3,0)--(3,-2)--(0,-2); 
\path
(-4,5) coordinate (A)
(-3,3) coordinate (B) 
(-1,2) coordinate (C)
(0,1.5) coordinate (D)
(1.5,1.8) coordinate (E)
(3,-2) coordinate (F);
\draw
(A) .. controls +(10:0.1) and +(180:0.5) ..
(B) .. controls +(0:.6) and +(-180:.6) ..
(C) .. controls +(0:.4) and +(-180:.4) ..
(D) .. controls +(0:.5) and +(180:.6) ..
(E) .. controls +(0:.6) and +(-95:0.1)..
(F);
\draw
(A)--+(100:0.2)
(F)--+(-75:0.2);
\draw
(-4.2,5.2)--(3.2,-2.2); 
\end{scope}
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 26,
    Title = "Đồ thị hàm số trên miền bị chặn",
    Category = "Phức tạp",
    Description = "Đồ thị hàm số bị chặn trong hình chữ nhật, đi qua các điểm (-4,5), (-3,3), (-1,2), (3,-2).",
    ImagePath = "Phuc_tap/phuctap26.png",
    Code = @"\begin{tikzpicture}[>=stealth, line join=round, line cap=round, font=\footnotesize, scale=0.6]
\def\xt{-5} \def\xp{6} \def\yd{-3} \def\yt{6}
\draw[->] (\xt,0)--(\xp,0) node[below]{$x$};
\draw[->] (0,\yd)--(0,\yt) node[left]{$y$};
\fill (0,0) circle (1.5pt) node[above left]{$O$};
\begin{scope}
\clip (\xt+0.1,\yd+0.1) rectangle (\xp-0.1,\yt-0.1);
\foreach \x in {-4,-3,-1,1,2,4,5}
\draw[thin] (\x,1pt)--(\x,-1pt) node [below] {$\x$};
\draw (3,0) node[above]{$3$};
\foreach \y in {-1,1,2,3,4,5}
\draw[thin] (1pt,\y)--(-1pt,\y)node [right] {$\y$};
\draw (0,-2)node [left] {$-2$};
\draw[dashed] (-4,0)--(-4,5)--(0,5) 
(-3,0)--(-3,3)--(0,3)
(-1,0)--(-1,2)--(0,2)
(3,0)--(3,-2)--(0,-2); 
\path
(-4,5) coordinate (A)
(-3,3) coordinate (B) 
(-1,2) coordinate (C)
(0,1.5) coordinate (D)
(1.5,1.8) coordinate (E)
(3,-2) coordinate (F);
\draw
(A) .. controls +(10:0.1) and +(180:0.5) ..
(B) .. controls +(0:.6) and +(-180:.6) ..
(C) .. controls +(0:.4) and +(-180:.4) ..
(D) .. controls +(0:.5) and +(180:.6) ..
(E) .. controls +(0:.6) and +(-95:0.1)..
(F);
\draw
(A)--+(100:0.2)
(F)--+(-75:0.2);
\end{scope}
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 27,
    Title = "Đồ thị hàm số qua 3 nghiệm x=-1, x=1, x=4",
    Category = "Phức tạp",
    Description = "Đồ thị hàm số trơn cắt trục hoành tại x=-1, x=1, có điểm ngoài đồ thị tại (4, 2.12).",
    ImagePath = "Phuc_tap/phuctap27.png",
    Code = @"\begin{tikzpicture}[>=stealth,scale=0.8]
\draw[->] (-2,0)--(5,0) node[below]{$x$};
\draw[->] (0,-2)--(0,2.5) node[right]{$y$};
\draw[dashed] (4,0)--(4,2.12);
\draw [fill=black] (0,0) node[below left]{$O$} circle (1pt);
\draw (-1,0) [fill=black] circle (1pt) node[below left]{$-1$};
\draw (1,0) [fill=black] circle (1pt) node[below]{$1$};
\draw (4,0) [fill=black] circle (1pt) node[below]{$4$};
\draw (4,2.12) [fill=black] circle (1pt);
\draw plot[smooth,samples=200,tension=.7] coordinates{(-1.5,2) (-1,0) (-0.5,-1.05) (0,-1.25) (0.5,-0.78) (1,0) (1.5,0.9) (2,1.45) (3,1.9) (4.4,2.2) (4.8,2.26)};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 28,
    Title = "Đồ thị hàm số dao động nhiều lần",
    Category = "Phức tạp",
    Description = "Đồ thị hàm số có nhiều điểm cực trị, đi qua điểm (-1,1) và có 6 điểm uốn, dạng dao động phức tạp.",
    ImagePath = "Phuc_tap/phuctap28.png",
    Code = @"\begin{tikzpicture}[scale=.7,font=\footnotesize,>=stealth,x=2cm,y=2cm]
%\draw[gray!20] (-2,-1) grid (1.5,1.5);
\draw[->] (-2.5,0)--(2,0) node[below]{$x$};
\draw[->] (0,-0.7)--(0,1.5) node[left]{$y$};
\coordinate[label=below left:$O$] (O) at (0,0);
\coordinate (A) at (-2.2,-.5);
\coordinate (X1) at (-1,1);
\coordinate (X2) at (-0.5,0.4);
\coordinate (X3) at (-0.3,0.6);
\coordinate (X4) at (0,0);
\coordinate (X5) at (0.8,0.8);
\coordinate (B) at (1.5,-0.5);
\draw[thick,black] 
(A) .. controls +(60:0.5) and +(180:0.4) ..
(X1) .. controls +(0:.2) and +(180:.2) ..
(X2) .. controls +(0:.05) and +(180:.05) ..
(X3) .. controls +(0:.1) and +(180:.1) .. 
(X4) .. controls +(0:.3) and +(180:.3).. 
(X5) .. controls +(0:.3) and +(105:.6).. 
(B);
\draw (-1,0)node[below]{$-1$} (1,0)node[below]{$1$} (0,1)node[right]{$1$};
\draw[dashed](-1,0)--(X1)--(0,1);
\foreach \p in {A,X1,X2,X3,X4,X5,B} 
\draw[fill=white] (\p) circle(1pt);
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 29,
    Title = "Đồ thị hàm số với đường thẳng y=-x",
    Category = "Phức tạp",
    Description = "Đồ thị hàm số đi qua các điểm (-1,1), (0,0), (1,-1), (2,-2) trên đường thẳng y=-x với dao động xung quanh.",
    ImagePath = "Phuc_tap/phuctap29.png",
    Code = @"\begin{tikzpicture}[>=stealth,scale=0.8, line join=round, line cap=round]
\draw[->] (-2,0)--(4,0) node [below]{$x$};
\draw[->] (0,-3.5)--(0,2.5) node [left]{$y$};
\node at (0,0) [below left]{$O$};
\draw[dashed] (-1,0) node[above left] {$-1$} -- (-1,1) -- (0,1)node[right] {$1$};
\draw[dashed] (1,0) node[above] {$1$} -- (1,-1) -- (0,-1)node[below right] {$-1$};
\draw[dashed] (2,0) node[above] {$2$} -- (2,-2) -- (0,-2)node[below right] {$-2$};
\draw plot[smooth,tension=0.7] coordinates{(-1.04,2) (-0.7,-3.1) (0.04,0.05) (1,-1) (1.6,-1.3) (2.2,-1.81) (2.5,2)};
\draw (-2,2)--(3,-3) node [above right]{\footnotesize $y=-x$};
\draw[fill=black] (-1,1) circle (1.5pt);
\draw[fill=black] (0,0) circle (1.5pt);
\draw[fill=black] (1,-1) circle (1.5pt);
\draw[fill=black] (2,-2) circle (1.5pt);
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 30,
    Title = "Đồ thị Parabol và đường thẳng nối tiếp",
    Category = "Phức tạp",
    Description = "Đồ thị gồm parabol y=-x²+2 và đoạn thẳng nối từ (2,-2) đến (3,3), liên tục tại x=2.",
    ImagePath = "Phuc_tap/phuctap30.png",
    Code = @"\begin{tikzpicture}[line cap=round,line join=round,x=1.0cm,y=1.0cm,>=stealth,scale=0.65, font = \footnotesize]
\draw[-> ] (-1.5,0) -- (3.5,0)node[below] {$x$};
\draw[-> ] (0,-2.3) -- (0,3.5)node[left] {$y$};
\draw(0,0) node[above left=-0.1] { $O$};
% \clip (-.5,-0.5) rectangle (2.3,2.8);
\draw [samples=100, domain=-1:2] plot (\x, {-( \x)*( \x ) + 2});
\draw[fill = black] (0,2) node[above left]{$ 2 $} circle (1pt);
\draw[fill = black] (0,-2) node[left]{$-2$} circle (1pt);
\draw[fill = black] (-1,0) node[below]{$-1$} circle (1pt);
\draw[fill = black] (2,0) node[above]{$2$} circle (1pt);
\draw[fill = black] (3,0) node[below]{$3$} circle (1pt);
\draw[fill = black] (0,3) node[left]{$3$} circle (1pt);
\draw[fill = black] (3,3)circle (1pt);
\draw[fill = black] (-1,1)circle (1pt);
\draw[fill = black] (2,-2)circle (1pt);
\draw (2,-2)--(3,3);
\draw[dashed] (0,-2)--(2,-2)--(2,0) (-1,0)--(-1,1)--(0,1) (0,3)--(3,3)--(3,0);
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 31,
    Title = "Đồ thị đạo hàm y=f'(x) hàm bậc năm",
    Category = "Phức tạp",
    Description = "Đồ thị đạo hàm y=x(x+2)(x-2)(x-5)(x-6)/30 có 5 nghiệm, dùng để lập bảng biến thiên của f(x).",
    ImagePath = "Phuc_tap/phuctap31.png",
    Code = @"\begin{tikzpicture}[scale=0.6, font=\footnotesize, line join=round, line cap=round, >=stealth,
declare function={
f(\x)= (\x)*(\x + 2)*(\x - 2)*(\x - 5)*(\x - 6)/30;
}
] 
\draw[->] (-2.5,0)--(7,0) node[below]{$x$};
\draw[->] (0,-2)--(0,5) node[left]{$y$}; 
\draw[smooth] plot[domain=-2.1:6.35] ({\x},{f(\x)}) node[above]{$y=f'(x)$}; 
\draw (0,0) circle (1pt) node[above left]{$O$};
\foreach \x in {-1,1,3,4} \draw[fill=black] (\x,0)circle (1pt) node[below]{$\x$}; 
\foreach \y in {-1,-2} \draw[fill=black] (0,\y)circle (1pt) node[left]{$\y$}; 
\foreach \y in {1, 2, 3, 4} \draw[fill=black] (0,\y)circle (1pt) node[right]{$\y$}; 
\foreach \x/\r in {-2/-135, 2/-45, 5/-135, 6/-45} \draw[fill=black] (\x,0) circle (1pt) node[shift={(\r:3mm)}]{$\x$}; 
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 32,
    Title = "Đồ thị hàm bậc bốn có nghiệm kép",
    Category = "Phức tạp",
    Description = "Đồ thị y=(x+1)(x-1)²(x-2)+1, có nghiệm kép tại x=1, đi qua các điểm (-1,1), (1,1), (2,1).",
    ImagePath = "Phuc_tap/phuctap32.png",
    Code = @"\begin{tikzpicture}[line join=round, line cap=round,>=stealth,scale=.9]
\draw[->](-2,0)--(3,0)node[above]{$x$};
\draw[->](0,-2.5)--(0,2.6)node[left]{$y$};
\foreach \x in {-1,1,2}
\draw[shift={(\x,0)},color=black]node[below left]{$\x$};
\foreach \y in {-1,1} \draw[shift={(0,\y)},color=black] (0pt,6pt) node[left] {$\y$};%điền số Oy
\draw[color=black] (0,0) node[above left] {$O$};%nhãn gốc toạ độ O
\draw[thick,samples=200,domain=-1.1:2.3] 
plot(\x,{(\x+1)*(\x-1)^2*(\x-2)+1});
\draw[dashed](-1,0)--(-1,1)--(2,1)--(2,0) (1,1)--(1,0);
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 33,
    Title = "Đồ thị hàm bậc năm dạng S kép",
    Category = "Phức tạp",
    Description = "Đồ thị hàm đa thức bậc 5 có 2 điểm uốn, đi qua các điểm đặc biệt x=-1, x=2, có dạng S kép.",
    ImagePath = "Phuc_tap/phuctap33.png",
    Code = @"\begin{tikzpicture}[scale=1, font=\footnotesize, line join=round, line cap =round, >=stealth,x=0.5cm,y=0.5cm]
\draw[->] (-3,0)--(0,0)%
node[below right]{$O$}--(4,0) node[below]{$x$};
\draw[->] (0,-2) --(0,3.5) node[below right]{$y$};
\draw[line width = 1pt] %
plot[domain=-2.3:3, samples=100] (\x, {0.03*(\x)^5+0.14*(\x)^4-0.45*(\x)^3-1.06*(\x)^2+0.66*(\x)+2.24});
\draw (-0.1,1)--(0.1,1) node[left]{$1$};
\draw (-1,-0.1)--(-1,0.1) node[below left]{$-1$};
\draw (2,-0.1)--(2,0.1) node[above]{$2$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 34,
    Title = "Đồ thị hàm bậc bốn có 1 cực trị",
    Category = "Phức tạp",
    Description = "Đồ thị hàm đa thức bậc 4 có 1 điểm cực tiểu, đi qua điểm (x=2, y≈1).",
    ImagePath = "Phuc_tap/phuctap34.png",
    Code = @"\begin{tikzpicture}[scale=1, font=\footnotesize, line join=round, line cap =round, >=stealth,x=0.5cm,y=0.5cm]
\draw[->] (-2,0)--(0,0)%
node[below right]{$O$}--(4,0) node[below]{$x$};
\draw[->] (0,-2) --(0,3) node[below right]{$y$};
\draw[line width = 1pt] %
plot[domain=-1.5:3.5, samples=100] (\x, {0.06*(\x)^4-0.07*(\x)^3-0.41*(\x)^2-0.21*(\x)+1.42});
\draw (-0.1,1)--(0.1,1) node[left]{$1$};
\draw (-1,-0.1)--(-1,-0.1) node[below left]{$-1$};
\draw (2,-0.1)--(2,0.1) node[above]{$2$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 35,
    Title = "Đồ thị hàm bậc năm có 2 cực trị",
    Category = "Phức tạp",
    Description = "Đồ thị hàm đa thức bậc 5 có 2 điểm cực trị, đi qua gốc tọa độ, đi qua các điểm x=-1, x=2.",
    ImagePath = "Phuc_tap/phuctap35.png",
    Code = @"\begin{tikzpicture}[scale=1, font=\footnotesize, line join=round, line cap =round, >=stealth,x=0.5cm,y=0.5cm]
\draw[->] (-2,0)--(0,0)%
node[below right]{$O$}--(3,0) node[below]{$x$};
\draw[->] (0,-2) --(0,3) node[below right]{$y$};
\draw[line width = 1pt] %
plot[domain=-1.5:2.8, samples=100] (\x, {0.13*(\x)^5-0.11*(\x)^4-1.1*(\x)^3+0.72*(\x)^2+1.57*(\x)});
\draw (-0.1,1)--(0.1,1) node[left]{$1$};
\draw (-1,-0.1) node[below left]{$-1$};
\draw (2,-0.1)--(2,0.1) node[above]{$2$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 36,
    Title = "Đồ thị nhiệt độ theo thời gian trong ngày",
    Category = "Phức tạp",
    Description = "Đồ thị nhiệt độ t(°C) theo thời gian x(giờ) trong 24 giờ, dao động từ 20°C đến 34°C, ứng dụng thực tế.",
    ImagePath = "Phuc_tap/phuctap36.png",
    Code = @"\begin{tikzpicture}[>=stealth,x=0.25cm,y=0.15cm]
\draw[->] (-2,0)--(0,0) node[below left]{$O$}--(28,0) node[below right]{$x$ (giờ)};
\draw[->] (0,-4)--(0,40) node[left]{$t$ ($^\circ C$)};
\foreach \x/\g in {4/-90,8/-90,12/-90,16/-90,20/-90,24/-90}
\draw[thin] (\x,2pt)--(\x,-2pt) + (\g:3mm) node {$\x$};
%Vẽ các điểm trên trục Oy
\foreach \y/\g in {25/180}
\draw[thin] (2pt,\y)--(-2pt,\y) + (\g:3mm) node {$\y$};
\path
(0,25) coordinate (25)
(4,20) coordinate (20)
(8,31) coordinate (31)
(12,28) coordinate (28)
(16,34) coordinate (34)
(20,27) coordinate (27)
(24,24) coordinate (24);
\draw [dashed] (4,0)--(4,20) (8,0)--(8,31) (12,0)--(12,28) (16,0)--(16,34) (20,0)--(20,27) (24,0)--(24,24); 
\draw[smooth, thick, red]
(25) .. controls +(-10:1) and +(-180:1) .. (20)
(20) .. controls +(0:1) and +(-180:1) .. (31)
(31) .. controls +(0:1) and +(160:1) .. (28)
(28) .. controls +(0:1) and +(-180:2) .. (34)
(34) .. controls +(0:1.5) and +(130:1.5) .. (27)
(27) .. controls +(-60:1.5) and +(-180:2) .. (24);
\foreach \x in {20,31,28,34,27,24}
\fill (\x) +(90:3mm) node {$\x$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 37,
    Title = "Đồ thị hàm bậc bốn đi qua 2 điểm biên",
    Category = "Phức tạp",
    Description = "Đồ thị hàm bậc 4 đi qua các điểm (-2, 2.5) và (6, 1.5), có 1 điểm cực trị trong khoảng.",
    ImagePath = "Phuc_tap/phuctap37.png",
    Code = @"\begin{tikzpicture}[line join=round, line cap=round,>=stealth,scale=.8]
\def\xmin{-3}\def\xmax{6.5}\def\ymin{-1}\def\ymax{3.5}
\draw[->] (\xmin-0.2,0)--(\xmax+0.2,0) node[below] {\small $x$};
\draw[->] (0,\ymin-0.2)--(0,\ymax+0.2) node[right] {\small $y$};
\draw (0,0) node [below left] {\footnotesize $O$};
\foreach \x in {-2,-1,2,6}\draw (\x,0.05)--(\x,-0.05) node [below] {\scriptsize $\x$};
\foreach \y in {-1,1,2,3}\draw (0.05,\y)--(-0.05,\y) node [left] {\scriptsize $\y$};
\clip (\xmin,\ymin) rectangle (\xmax,\ymax);
\draw[thick,smooth,samples=200,domain=-2:6] plot (\x,{13/3360*(\x)^4-61/672*(\x)^3+173/336*(\x)^2-11/42*(\x)-61/70});
\draw[dashed](-2,0)|-(0,2.5)(6,0)|-(0,1.5);
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 38,
    Title = "Đồ thị hàm số có điểm uốn nằm ngang",
    Category = "Phức tạp",
    Description = "Đồ thị hàm số có điểm uốn nằm ngang tại x=2, tiếp cận giá trị y≈1.3 khi x→5.",
    ImagePath = "Phuc_tap/phuctap38.png",
    Code = @"\begin{tikzpicture}[scale=1, font=\footnotesize, line join=round, line cap=round, >=stealth]
\draw[->](-1,0)--(5.5,0) node[right] {$x$};
\draw[->](0,-1)--(0,2.5) node[right] {$y$};
\node (0,0) [below left]{$O$};
\foreach \x in {1,...,5}
\draw[shift={(\x,0)},color=black] (0pt,2pt) -- (0pt,-2pt);
\foreach \y in {1,...,2}
\draw[shift={(0,\y)},color=black] (2pt,0pt) -- (-2pt,0pt);
\draw (-0.3,1.2) .. controls (0.1,-1.8) and (1.5,-0.5) .. (2,0) .. controls (3,1.) and (4,1.2) .. (5,1.3) .. controls (5.1,1.3) and (5.3,1.3) .. (5.5,1.3);
\clip (-1,-1) rectangle (5.5,2.5);
\draw[dashed](5,0)--(5,1.3);
\fill (0,0) circle(1pt) (2,0) circle(1pt) node[below right]{$2$} (5,0) circle(1pt) node[below]{$5$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 39,
    Title = "Đồ thị hàm bậc bốn có 2 cực trị",
    Category = "Phức tạp",
    Description = "Đồ thị hàm đa thức bậc 4 có 1 điểm cực tiểu và 1 điểm cực đại, đi qua các điểm x=-1, x=2.",
    ImagePath = "Phuc_tap/phuctap39.png",
    Code = @"\begin{tikzpicture}[scale=1, font=\footnotesize, line join=round, line cap =round, >=stealth,x=0.5cm,y=0.5cm]
\draw[->] (-2,0)--(0,0)%
node[above right]{$O$}--(3.5,0) node[below]{$x$};
\draw[->] (0,-2) --(0,3.5) node[below right]{$y$};
\draw[line width = 1pt] %
plot[domain=-1.55:2.5, samples=100] (\x, {0.01*(\x)^4-0.15*(\x)^3+0.59*(\x)^2+0.15*\x-0.6});
\draw (-0.1,1)--(0.1,1) node[left]{$1$};
\draw (-1,-0.1) node[below left]{$-1$};
\draw (2,-0.1)--(2,0.1) node[below]{$2$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 40,
    Title = "Đồ thị đạo hàm y=f'(x) hai nhánh parabol",
    Category = "Phức tạp",
    Description = "Đồ thị hàm đạo hàm y=f'(x) gồm hai nhánh parabol, có nghiệm x=0, x=2, x=4.",
    ImagePath = "Phuc_tap/phuctap40.png",
    Code = @"\begin{tikzpicture}[scale=0.79, >=stealth]
\draw[->] (-0.6,0.) -- (5.3,0.);
\draw[->] (0.,-1.7) -- (0.,1.6);
\draw[dashed] (4,0) -- (4,-1.2);
\clip(-0.6,-1.7) rectangle (5.3,1.7);
\draw[smooth,samples=100,domain=0:2] plot(\x,{-0.8*((\x)^2-2*(\x))});
\draw[smooth,samples=100,domain=2:4.5] plot(\x,{0.2*(((\x)-2)*((\x)-7)});
\draw (-0.3,-0.3) node {$O$} (5.2,0.3) node {$x$} (0.35,1.5) node {$y$} (1.9,-0.3) node {$2$} (4.0,0.3) node {$4$} (2.0,1.15) node {$y=f'(x)$};
\fill (0,0) circle(1pt) (2,0) circle(1pt) (4,0) circle(1pt); 
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 41,
    Title = "Đồ thị hàm số có 5 điểm đặc biệt",
    Category = "Phức tạp",
    Description = "Đồ thị hàm số đi qua các điểm (-1,-2), (0,1), (2,-2), (3,1), (4,3), (5,1) với nhiều điểm cực trị.",
    ImagePath = "Phuc_tap/phuctap41.png",
    Code = @"\begin{tikzpicture}[scale=0.65, font=\footnotesize, line join=round, line cap=round, >=stealth]
%%Nhập giới hạn đồ thị và hàm số cần vẽ
\def \xmin{-1.5}
\def \xmax{6.3}
\def \ymin{-2.8}
\def \ymax{4}
%%Tự động
\draw[->] (\xmin,0)--(\xmax,0) node[below left] {$x$};
\draw[->] (0,\ymin)--(0,\ymax) node[below left] {$y$};
\draw[fill=black] (0,0) circle(1pt) node [below right] {$O$};
%%Vẽ các điểm trên 2 hệ trục
\foreach \x in {3,4,5}
\draw[fill=black] (\x,0) circle(1pt) node [below] {$\x$};
\foreach \x in {-1,2}
\draw[fill=black] (\x,0) circle(1pt) node [above] {$\x$};
\foreach \y in {-2,1,3}
\draw[fill=black] (0,\y) circle(1pt) node [above right] {$\y$};
\draw[dashed](-1,0)--(-1,-2)--(0,-2)--(2,-2)--(2,0) (5,0)--(5,1)--(0,1) (3,0)--(3,1) (4,0)--(4,3)--(0,3);
%%Tự động
\draw
(-1.1,-2.7) to[out=80, in=-100] (-1,-2)
..controls +(80:1.2) and +(180:.5)..(0,1)
..controls +(0:.6) and +(180:0.7)..(2,-2)
..controls +(0:0.4) and +(-100:1.2)..(2.8,0)
to[in=80, out=-100] (3,1)
..controls +(75:1.5) and +(180:0.3)..(4,3)
..controls +(0:0.5) and +(-75:1)..(5,1)
to[in=105, out=-75] (6,-2.7);
\fill[black]
(-1,-2) circle(1pt)
(2,-2) circle(1pt)
(3,1) circle(1pt)
(4,3) circle(1pt)
(5,1) circle(1pt)
;
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 42,
    Title = "Đồ thị Parabol với giá trị lớn nhất và nhỏ nhất",
    Category = "Phức tạp",
    Description = "Đồ thị y=0.5(x²-4x+1) trên [a,b], có y_max=f(a)=3 tại x=-1, y_min=f(x₀)=-1.5 tại x=2.",
    ImagePath = "Phuc_tap/phuctap42.png",
    Code = @"\begin{tikzpicture}[smooth,samples=300,scale=0.7,>=stealth]
\draw[->] (-1.5,0)--(4.8,0) node[below]{$x$};
\draw[->] (0,-2)--(0,4) node[right]{$y$};
\draw (0,0) node[above left]{$O$};
\draw[line width = 1.2pt,domain=-1:4,blue] plot(\x,{0.5*((\x)^2-4*(\x)+1)});
\draw[fill=black] (-1,0) circle(1.5pt) (-1,3) circle(2pt) (0,3) circle(1.5pt) (0,-1.5) circle(1.5pt) (2,0) circle(1.5pt) (2,-1.5) circle(2pt) (4,0) circle(1.5pt) (4,0.5) circle(1.5pt);
\draw[dashed] (-1,0)node[below]{\small$a$}--(-1,3)--(0,3)node[right]{\small$f(a)$} (2,0)node[above]{\small$x_0$}--(2,-1.5)--(0,-1.5)node[left]{\small$f(x_0)$}
(4,0)node[below]{\small$b$}--(4,0.5);
\node[above] at (-1,3) {\small $y_{\max}$};
\node[below] at (2,-1.5) {\small $y_{\min}$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 43,
    Title = "Đồ thị minh họa nghiệm bội chẵn và bội lẻ",
    Category = "Phức tạp",
    Description = "Đồ thị y=f'(x) có nghiệm bội lẻ tại x₁, x₃ (đổi dấu) và nghiệm bội chẵn tại x₂, x₄ (không đổi dấu).",
    ImagePath = "Phuc_tap/phuctap43.png",
    Code = @"\begin{tikzpicture}[smooth,samples=300,scale=0.8,>=stealth,font=\footnotesize]
\draw[->] (-3.5,0)--(6,0) node[below]{$x$};
\draw[->] (0,-1.5)--(0,4) node[left]{$y$};
\draw (0,0) node[above left]{$O$};
\draw[blue,line width=0.7pt,domain=-2.15:1.5] plot(\x,{(\x+2)*(\x-1)^2});
\draw[blue,line width=0.7pt,domain=1.5:4.7] plot(\x,{-1*(\x-1.64)*(\x-4)^2})node[below]{$y=f'(x)$};
\draw[fill=red] (-2,0)node[above left]{$x_1$} circle(1.5pt) (1,0)node[below]{$x_2$} circle(1.5pt) (4,0)node[above right]{$x_4$} circle(1.5pt) (1.64,0)node[above right]{$x_3$} circle(1.5pt);
\draw[dashed,<-] (-1.8,-0.2)--(0.5,-2.3)node[below]{\fbox{\scriptsize\text{Nghiệm bội lẻ}}};
\draw[dashed,->](0.5,-2.3)--(1.58,-0.2);
\draw[dashed,<-] (1,0.2)--(2,3)node[above]{\fbox{\scriptsize\text{Nghiệm bội chẵn}}};
\draw[dashed,->](2,3)--(3.9,0.1);
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 44,
    Title = "Hai đồ thị y=f(x) và y=g(x) trên lưới",
    Category = "Phức tạp",
    Description = "Đồ thị parabol y=f(x) và đồ thị gấp khúc y=g(x) trên lưới tọa độ, minh họa bài toán so sánh hàm số.",
    ImagePath = "Phuc_tap/phuctap44.png",
    Code = @"\begin{tikzpicture}[>=stealth,scale=0.7]
\draw[->] (-1.2,0)--(0,0) node[below left]{$O$}--(7.5,0) node[below]{$x$};
\draw[->] (0,-0.8)--(0,5) node[right]{$y$};
\foreach \x in {1,2,3,4,5,6,7}\draw (\x,0) node[below]{$\x$};%Ox
\foreach \y in {1,2,3,4}\draw (0,\y) node[left]{$\y$};%Oy
\draw[violet,dashed,line width=0.2pt] (0,0) grid (7,4.5);
\draw [blue, line width=1.5pt] (0,0)--(4,2)--(7,2);
\draw [red, line width=1.5pt, domain=0.5:3.5, samples=100] plot (\x, {(\x)^2 -4*(\x)+6});
\draw (3.1,3.4) node[right]{\footnotesize$y=f(x)$} (5,1.5) node[right]{\footnotesize $y=g(x)$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 45,
    Title = "Đồ thị hàm bậc bốn y=x⁴-2x²-1",
    Category = "Phức tạp",
    Description = "Đồ thị hàm bậc 4 trên lưới, có 2 điểm cực tiểu và 1 điểm cực đại, đối xứng qua trục y.",
    ImagePath = "Phuc_tap/phuctap45.png",
    Code = @"\begin{tikzpicture}[>=stealth,scale=1]
\draw[->] (-3,0)--(0,0)%
node[below left]{$O$}--(3,0) node[below]{$x$};
\draw[->] (0,-2) --(0,2) node[right]{$y$};
\draw[violet,dashed,line width=0.2pt] (-3,-2) grid (3,2);
\draw [blue, line width=1pt, domain=-1.7:1.7, samples=100] %
plot (\x, {(\x)^4 -2*(\x)^2-1});
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 46,
    Title = "Đồ thị hàm bậc ba y=x³-3x",
    Category = "Phức tạp",
    Description = "Đồ thị hàm bậc 3 trên lưới, có 1 điểm cực đại và 1 điểm cực tiểu, dạng chữ S.",
    ImagePath = "Phuc_tap/phuctap46.png",
    Code = @"\begin{tikzpicture}[>=stealth,scale=1]
\draw[->] (-3,0)--(0,0)%
node[below left]{$O$}--(3,0) node[below]{$x$};
\draw[->] (0,-2) --(0,2) node[right]{$y$};
\draw[violet,dashed,line width=0.2pt] (-3,-2) grid (3,2);
\draw [red, line width=1pt, domain=-1.94:1.94, samples=100] %
plot (\x, {(\x)^3 -3*(\x)});
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 47,
    Title = "Đồ thị Parabol y=40+18x-x² với giá trị max",
    Category = "Phức tạp",
    Description = "Đồ thị parabol ngược y=40+18x-x², đạt giá trị lớn nhất y=121 tại x=9, ứng dụng bài toán tối ưu.",
    ImagePath = "Phuc_tap/phuctap47.png",
    Code = @"\begin{tikzpicture}[line cap=round,line join=round,>=stealth,x=0.1cm,y=0.1cm, scale=0.4]
\draw[->,color=black] (0,0.) -- (30,0.);
\foreach \x in {9,20}
\draw[shift={(\x,0)},color=black] (0pt,2pt) -- (0pt,-2pt) node[below] {\footnotesize $\x$};
\draw[->,color=black] (0.,0) -- (0.,130);
\foreach \y in {121}
\draw[shift={(0,\y)},color=black] (2pt,0pt) -- (-2pt,0pt) node[left] {\footnotesize $\y$};
\draw[color=black] (0pt,-10pt) node[left] {\footnotesize $O$};
\clip(0,0) rectangle (30,130);
\draw[line width=1.0pt,color=black,smooth,samples=100,domain=0:20] plot(\x,{40+18*\x-(\x)^2});
\draw [dash pattern=on 2pt off 2pt] (9,0)--(9,121)--(0,121);
\draw (28, 3) node {$x$}; \draw (3,128) node {$y$};
\end{tikzpicture}"
},

