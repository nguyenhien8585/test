new TikzItem2 
{
    Id = 1,
    Title = "Đồ thị y = (x+1)e^x",
    Category = "Mũ logarit",
    Description = "Đồ thị hàm số y = (x+1)e^x qua điểm (0,1) và có nghiệm tại x = -1.",
    ImagePath = "Mu_logarit/mulogarit1.png",
    Code = @"\begin{tikzpicture}[smooth,samples=300,scale=0.7,>=stealth,font=\footnotesize]
		\draw[->] (-2,0)--(1,0) node[below]{$x$};
		\draw[->] (0,-1)--(0,2.5) node[left]{$y$};
		\draw (0,0) node[below left,]{$O$};
		\draw[line width=0.7pt,domain=-2:0.5] plot(\x,{(\x+1)*e^(\x)});
		\draw[fill=black] (0,1) circle(1.5pt) (-1,0) circle(1.5pt);
		\node[right] at (0,1) {$1$};
		\node[above] at (-1,0) {$-1$};
		\end{tikzpicture}"
},

new TikzItem2
{
    Id = 2,
    Title = "Đồ thị y = 0.4^x",
    Category = "Mũ logarit",
    Description = "Đồ thị hàm số mũ cơ số 0 < a < 1, qua điểm (0,1).",
    ImagePath = "Mu_logarit/mulogarit2.png",
    Code = @"\begin{tikzpicture}[smooth,samples=300,scale=0.7,>=stealth,font=\footnotesize]
		\draw[->] (-1,0)--(2,0) node[below]{$x$};
		\draw[->] (0,-1)--(0,2.5) node[right]{$y$};
		\draw (0,0) node[below left,]{$O$};
		\draw[line width=0.7pt,domain=-1:1.8] plot(\x,{0.4^(\x)});
		\draw[fill=black] (0,1) circle(1.5pt);
		\node[right] at (0,1) {$1$};
		\end{tikzpicture}"
},

new TikzItem2
{
    Id = 3,
    Title = "Đồ thị y = log_a x và y = log_b x",
    Category = "Mũ logarit",
    Description = "So sánh hai đồ thị logarit với cơ số khác nhau qua điểm M(9,y), có điểm N và P.",
    ImagePath = "Mu_logarit/mulogarit3.png",
    Code = @"\begin{tikzpicture}[scale=0.6]	
		%\clip(-1, -1) rectangle (8, 8);
		\draw[->] (-1,0) --(0,0) node[below left]{$O$}--(8.5,0) node[below]{$x$};
		\draw[->] (0,-2.5) --(0,4.5) node[right]{$y$};
		\draw (6,0) node[below right]{$9$} circle (1.5pt);
		\draw (6,0) node[above left]{$M$} circle (1.5pt);
		\draw (6,1.8) node[above left]{$N$} circle (1.5pt);
		\draw (6,3.6) node[above left]{$P$} circle (1.5pt);
		\draw [samples=100, domain=0.3:8] plot (\x, {(ln(\x))}) (6,2.3) node[right]{\footnotesize $y = \log_{a}x$};
		\draw [samples=100, domain=0.4:8] plot (\x, {2*(ln(\x))}) (6,4.4) node[right]{\footnotesize $y = \log_{b}x$};
		\draw [-] (6,0)--(6,3.63);
		\end{tikzpicture}"
},

new TikzItem2
{
    Id = 4,
    Title = "Đồ thị y = e^x",
    Category = "Mũ logarit",
    Description = "Đồ thị hàm số mũ cơ số e qua điểm (0,1).",
    ImagePath = "Mu_logarit/mulogarit4.png",
    Code = @"\begin{tikzpicture}[smooth,samples=300,scale=0.7,>=stealth,font=\footnotesize]
		\draw[->] (-2,0)--(1,0) node[below]{$x$};
		\draw[->] (0,-1)--(0,2.5) node[left]{$y$};
		\draw (0,0) node[below left,]{$O$};
		\draw[line width=0.7pt,domain=-2:0.9] plot(\x,{e^(\x)});
		\draw[fill=black] (0,1) circle(1.5pt);
		\node[right] at (0,1) {$1$};
		\end{tikzpicture}"
},

new TikzItem2
{
    Id = 5,
    Title = "Đồ thị y = 2^x, y = 3^x và y = log_(1/2) x",
    Category = "Mũ logarit",
    Description = "So sánh 3 đồ thị: C₁ là y = 3^x, C₂ là y = 2^x, C₃ là y = log_(1/2) x.",
    ImagePath = "Mu_logarit/mulogarit5.png",
    Code = @"\begin{tikzpicture}[scale=0.6,>=stealth]
		\draw[->](0,-1.5)--(0,5) node [left] {$y$};
		\draw[->](-2.5,0)--(3.5,0) node [below] {$x$};
		%\clip (-1.5,5)rectangle (3.5,-3);
		\draw[smooth,samples=100,domain=-1.5:2] plot({\x},{(2)^(\x)}) node[right]{$ C_2 $};
		\draw[smooth,samples=100,domain=-1.5:1.3] plot({\x},{(3)^(\x)}) node[above]{$ C_1 $};
		\draw[smooth,samples=100,domain=.06:2.5] plot(\x,{ln(\x)/ln(1/2)})node[above] {$C_3$}; 	
		\node at (-0.3,-0.3) {$O$};
		\node[above left] at (0,1) {$1$};
		\node[below] at (1,0) {$1$};
		\draw[fill=black] (0,1) circle (1pt);
		\draw[fill=black] (1,0) circle (1pt);  
		\draw[fill=black] (0,0) circle (1pt);  
		\end{tikzpicture}"
},

new TikzItem2
{
    Id = 6,
    Title = "Đồ thị y = a^x, y = b^x và y = c^x với x = 1",
    Category = "Mũ logarit",
    Description = "So sánh 3 hàm mũ tại x = 1 để xác định thứ tự a < 1 < c < b.",
    ImagePath = "Mu_logarit/mulogarit6.png",
    Code = @"\begin{tikzpicture}
			\draw[->] (-3,0)--(0,0) node[below left]{$O$}--(4,0) node[below] {$x$};
			\draw[->] (0,-1)-- (0,5) node[left]{$y$};
			\node[left] at (-.2,1) {$1$};
			\draw[-](1,-.7) node[below]{$x=1$}--(1,0) node[below left]{$1$}--(1,3.5);
			\draw[-][dashed](1,.5556)--(0,.5556) node[left]{$a$};
			\draw[-][dashed](1,1.8)--(0,1.8) node[left]{$c$};
			\draw[-][dashed](1,2.5)--(0,2.5) node[left]{$b$};
			\draw[-][dashed](1,1)--(0,1);
			\draw[smooth,samples=100,domain=-2.5:2.5] plot(\x,{1/(1.8^(\x))}) node[above right]{$y=a^x$};
			\draw[smooth,samples=100,domain=-2.5:1.5] plot(\x,{2.5^(\x)}) node[above]{$y=b^x$};
			\draw[smooth,samples=100,domain=-2.5:2.5] plot(\x,{1.8^(\x)}) node[right]{$y=c^x$};
			\end{tikzpicture}"
},

new TikzItem2
{
    Id = 7,
    Title = "Đồ thị y = a^x, y = b^x và y = c^x",
    Category = "Mũ logarit",
    Description = "So sánh 3 đồ thị hàm mũ với cơ số khác nhau: a < 1 < c < b.",
    ImagePath = "Mu_logarit/mulogarit7.png",
    Code = @"\begin{tikzpicture}[scale=0.6]
		\draw[->] (-3,0)--(0,0) node[below left]{$O$}--(4,0) node[below] {$x$};
		\draw[->] (0,-1)-- (0,5) node[left]{$y$};
		\node[left] at (-.2,1) {$1$};
		\draw[smooth,samples=100,domain=-2.5:2.5] plot(\x,{1/(1.8^(\x))}) node[above right]{$y=a^x$};
		\draw[smooth,samples=100,domain=-2.5:1.5] plot(\x,{2.5^(\x)}) node[above]{$y=b^x$};
		\draw[smooth,samples=100,domain=-2.5:2.5] plot(\x,{1.8^(\x)}) node[right]{$y=c^x$};
		\end{tikzpicture}"
},

new TikzItem2
{
    Id = 8,
    Title = "Đồ thị hàm logarit với các điểm A, B, H",
    Category = "Mũ logarit",
    Description = "Hai đồ thị logarit với cơ số khác nhau, có điểm H(2,0), A và B trên hai đồ thị.",
    ImagePath = "Mu_logarit/mulogarit8.png",
    Code = @"\begin{tikzpicture}[>=stealth,scale=0.8, font=\footnotesize, line join=round, line cap=round]
			\draw[->](-0.5,0)--(3,0)node[below]{$x$};
			\draw[->](0,-2.5)--(0,2.4)node[left]{$y$};
			\draw[smooth, samples=100, domain=0.07:3]plot(\x,{log10(\x)/log10(0.3)});
			\draw[smooth, samples=100, domain=0.12:3]plot(\x,{log10(\x)/log10(2.47)});
			\draw(2,-0.576)--(2,0)--(2,0.767);
			\fill (0,0)node[above left]{\footnotesize{$O$}}circle(1.2pt) (2,-0.576)node[below]{\footnotesize{$B$}}circle(1.2pt) (2,0)node[above right]{\footnotesize{$H$}}circle(1.2pt) (2,0.767)node[above]{\footnotesize{$A$}}circle(1.2pt);
	\end{tikzpicture}"
},

new TikzItem2
{
    Id = 9,
    Title = "Đồ thị y = x^a, y = x^b và y = x^c",
    Category = "Mũ logarit",
    Description = "So sánh 3 đồ thị hàm lũy thừa với số mũ khác nhau trên lưới ô vuông.",
    ImagePath = "Mu_logarit/mulogarit9.png",
    Code = @"\begin{tikzpicture}[>=stealth,x=1.0cm,y=1.0cm,scale=0.6,thick]
		\draw [color=gray!30,, xstep=1.0cm,ystep=1.0cm] (-1.26,-1.2) grid (6.64,4.76);
		\draw[->,color=black] (-1.26,0.) -- (6.64,0.) node[below] {\large $x$};
		\draw[->,color=black] (0,-1.2) -- (0.,4.76) node[left] {\large $y$};
		\draw (0,0) node[below left] {$O$} ;
		\draw (2.5,4) node[left] {$y=x^a$};
		\draw (4.5,4.5) node[right] {$y=x^b$};
		\draw (5,2.8) node[right] {$y=x^c$};
		\clip(-1.26,-1.5) rectangle (6.64,4.76);
		\draw[color=blue,smooth,samples=100,domain=0:6.64] plot(\x,{(\x)^(2/3)});
		\draw[color=cyan,smooth,samples=100,domain=0:6.64] plot(\x,{(\x)^(3/2)});
		\draw[color=red,smooth,samples=100,domain=0:6.64] plot(\x,{(\x)});
		\end{tikzpicture}"
},

new TikzItem2
{
    Id = 10,
    Title = "Đồ thị y = x^α và y = x^β",
    Category = "Mũ logarit",
    Description = "So sánh hai đồ thị hàm lũy thừa với α > 1 và 0 < β < 1.",
    ImagePath = "Mu_logarit/mulogarit10.png",
    Code = @"\begin{tikzpicture}[line cap=round,line join=round,>=stealth,x=0.8cm,y=0.8cm]
		%\draw [color=gray!50,, xstep=1.0cm,ystep=1.0cm] (-2.,-5) grid (4,2);
		\draw[->,color=black] (-1.,0.) -- (4,0.);
		\foreach \x in {1}
		\draw[shift={(\x,0)},color=black] (0pt,2pt) -- (0pt,-2pt) node[below] {$\x$};
		\draw[->,color=black] (0.,-1) -- (0.,4);
		\foreach \y in {1}
		\draw[shift={(0,\y)},color=black] (2pt,0pt) -- (-2pt,0pt) node[left] {$\y$};
		\draw[color=black] (0,0) node[below right] {$O$};
		\clip(-1.,-1) rectangle (4,4);
		\draw[line width=1.2pt,smooth,samples=100,domain=0:5] plot(\x,{(\x)^(2.0)});
		\draw[line width=1.2pt,smooth,samples=100,domain=0:5] plot(\x,{(\x)^(0.5)});
		\draw[color=black] (4,0) node[above left] {$x$};
		\draw[color=black] (0,4) node[below right] {$y$};
		\draw[color=black] (1.5,3) node[below right] {$y=x^{\alpha}$};
		\draw[color=black] (2,1.7) node[below right] {$y=x^{\beta}$};
		\draw[dashed] (1,0)--(1,1);
		\draw[dashed] (0,1)--(1,1);
		\end{tikzpicture}"
},

new TikzItem2
{
    Id = 11,
    Title = "Đồ thị y = 2^x",
    Category = "Mũ logarit",
    Description = "Đồ thị hàm số mũ cơ số 2.",
    ImagePath = "Mu_logarit/mulogarit11.png",
    Code = @"\begin{tikzpicture}[scale=0.6,>=stealth,x=1cm,
		y=1cm]
		\def \xmin{-2.5}
		\def \xmax{3.5}
		\def \ymin{-0.66}
		\def \ymax{3.98}
		% Vẽ 2 trục, điền các số lên trục
		\draw[->] (\xmin,0) -- (\xmax,0);
		\draw[->,color=black] (0,\ymin) -- (0,\ymax);
		\draw[color=black](\xmax-0.3,.2)node[right] {$x$};
		\draw[color=black] (.1,\ymax) node[right] {\normalsize $y$};
		\draw[color=black] (0pt,-8pt) node[left] {\normalsize $O$};
		\begin{scope}
		\clip(\xmin ,\ymin) rectangle (\xmax-1,\ymax-0.5);
		%Vẽ đồ thị
		\draw[smooth,samples=100,domain=\xmin:\xmax] 
		plot(\x,{2^(\x)});
		\end{scope}
		\node at (-.3,1.3){1};
		\end{tikzpicture}"
},

new TikzItem2
{
    Id = 12,
    Title = "Đồ thị y = log₃ x",
    Category = "Mũ logarit",
    Description = "Đồ thị hàm logarit cơ số 3 qua điểm (1,0) và (3,1).",
    ImagePath = "Mu_logarit/mulogarit12.png",
    Code = @"\begin{tikzpicture}[scale=0.7, font=\footnotesize, line join=round, line cap=round, >=stealth]
			\draw[->](-1,0)--(5,0)node[below]{$x$};
			\draw[->](0,-2)--(0,3)node[left]{$y$};
			\draw [fill=black,draw=black] (0,0) circle (1pt)node[below left] {$O$} (1,0) circle (1pt)node[below] {$1$} (3,0) circle (1pt)node[below] {$3$} (0,1) circle (1pt)node[left] {$1$} (3,1) circle (1pt);
			\draw[dashed] (3,0)--(3,1)--(0,1);
			\clip(-1,-2) rectangle (5,3);
			\draw[smooth,samples=100,domain=0.1:5] plot(\x,{ln(\x)/ln(3)});
	\end{tikzpicture}"
},

new TikzItem2
{
    Id = 13,
    Title = "Đồ thị y = log_a x và y = log_b x",
    Category = "Mũ logarit",
    Description = "So sánh hai đồ thị logarit: cơ số a > 1 (đồng biến) và cơ số 0 < b < 1 (nghịch biến).",
    ImagePath = "Mu_logarit/mulogarit13.png",
    Code = @"\begin{tikzpicture}[scale=0.7, font=\footnotesize, line join=round, line cap=round, >=stealth]
			\draw[->](-1,0)--(7,0)node[below]{$x$};
			\draw[->](0,-3)--(0,3)node[left]{$y$};
			\draw [fill=black,draw=black] (0,0) circle (1pt)node[above left] {$O$} (1,0) circle (1pt)node[below] {$1$} (6,2.5) node[below] {$y=\log_a x$} (6,-2.5) node[above] {$y=\log_b x$};
			\clip(-1,-3) rectangle (7,3);
			\draw[smooth,samples=100,domain=0.1:7] plot(\x,{ln(\x)/ln(2)});
			\draw[smooth,samples=100,domain=0.1:7] plot(\x,{ln(\x)/ln(0.5)});
	\end{tikzpicture}"
},

new TikzItem2
{
    Id = 14,
    Title = "Đồ thị y = 2^x",
    Category = "Mũ logarit",
    Description = "Đồ thị hàm số mũ y = 2^x với đường nét đứt qua (1,2).",
    ImagePath = "Mu_logarit/mulogarit14.png",
    Code = @"\begin{tikzpicture}[line width=0.6pt,>=stealth,scale=1]
		\draw[->] (-2,0)--(2,0) node[below]{$x$};
		\draw[->] (0,-0.5)--(0,3) node[left]{$y$};
		\node at (0,0) [below left]{$O$};
		\draw[domain=-1.9:1.5] plot(\x,{2^(\x)});
		\draw[dashed] (1,0)--(1,2)--(0,2);
		\node at (0,1.2) [left]{$1$};
		\node at (0,2) [left]{$2$};
		\node at (1,0) [below]{$1$};
		\end{tikzpicture}"
},

new TikzItem2
{
    Id = 15,
    Title = "Đồ thị y = 0.5^(x+1) và y = m-1",
    Category = "Mũ logarit",
    Description = "Đồ thị hàm mũ y = 0.5^(x+1) với đường thẳng y = m-1.",
    ImagePath = "Mu_logarit/mulogarit15.png",
    Code = @"\begin{tikzpicture}[>=stealth]
			\draw[->,line width = 1pt] (-3.5,0)--(0,0) node[below right]{$O$}--(4,0) node[below]{$x$};
			\draw[->,line width = 1pt] (0,-1.5) --(0,3.6) node[right]{$y$};
			\foreach \x in {-3,-2,-1,1,2,3}{
				\draw (\x,0) node[below]{$\x$} circle (1pt);
			}
			\foreach \x in {-1,1,2,3}{
				\draw (0,\x) node[left]{$\x$} circle (1pt);
			}
			\draw [thick, domain=-2.5:3.25, samples=100] %
			plot (\x,{(0.5)^(\x+1)});
			
			\draw [thick, domain=-3:3.5, samples=100] %
			plot (\x, {1.5}) node[above]{$m-1$};;
			\end{tikzpicture}"
},

new TikzItem2
{
    Id = 16,
    Title = "Đồ thị y = a^x và y = b (a > 1)",
    Category = "Mũ logarit",
    Description = "Đồ thị hàm mũ với a > 1 cắt đường y = b tại x = log_a b.",
    ImagePath = "Mu_logarit/mulogarit16.png",
    Code = @"\begin{tikzpicture}[smooth,samples=300,scale=0.8,>=stealth]
	\draw[->] (-2,0)--(3,0) node[below]{$x$};
	\draw[->] (0,-1)--(0,4) node[right]{$y$};
	\draw (0,0) node[below left]{$O$};
	\draw[dashed,color=blue,domain=-2:1] plot(\x,{2^(\x)});
	\draw[line width=1pt,color=blue,domain=1:1.8] plot(\x,{2^(\x)})node[right]{$y=a^x$};
	\draw[color=red!60!black,line width=1pt] (-2,2)--(3,2) node[below]{$y=b$};
	\draw[dashed] (1,0)node[below]{\small$\log_ab$}--(1,2);
	\draw[fill=black](1,2) circle(2pt);
	\node[left] at (0,2.35) {$b$};
	\end{tikzpicture}"
},

new TikzItem2
{
    Id = 17,
    Title = "Đồ thị y = a^x và y = b (0 < a < 1)",
    Category = "Mũ logarit",
    Description = "Đồ thị hàm mũ với 0 < a < 1 cắt đường y = b tại x = log_a b.",
    ImagePath = "Mu_logarit/mulogarit17.png",
    Code = @"\begin{tikzpicture}[smooth,samples=300,scale=0.8,>=stealth]
	\draw[->] (-2,0)--(3,0) node[below]{$x$};
	\draw[->] (0,-1)--(0,4) node[right]{$y$};
	\draw (0,0) node[below right]{$O$};
	\draw[dashed,color=blue,domain=-1:1.8] plot(\x,{0.5^(\x)})node[above right]{$y=a^x$};
	\draw[line width=1pt,color=blue,domain=-2:-1] plot(\x,{0.5^(\x)});
	\draw[color=red!60!black,line width=1pt] (-2,2)--(3,2) node[above]{$y=b$};
	\draw[dashed] (-1,0)node[below]{\small$\log_ab$}--(-1,2);
	\draw[fill=black](-1,2) circle(2pt);
	\node[left] at (0,2.35) {$b$};
	\end{tikzpicture}"
},

new TikzItem2
{
    Id = 18,
    Title = "Đồ thị y = log_a x và y = b (a > 1)",
    Category = "Mũ logarit",
    Description = "Đồ thị logarit với a > 1 cắt đường y = b tại x = a^b.",
    ImagePath = "Mu_logarit/mulogarit18.png",
    Code = @"\begin{tikzpicture}[smooth,samples=300,scale=0.8,>=stealth]
	\draw[->] (-1,0)--(4,0) node[below]{$x$};
	\draw[->] (0,-2.5)--(0,3) node[right]{$y$};
	\draw (0,0) node[below left]{$O$};
	\draw[dashed,black,domain=0.2:2]plot(\x,{ln((\x))/ln(2)});
	\draw[line width=0.8pt,black,domain=2:3.2]plot(\x,{ln((\x))/ln(2)})node[above right]{$y=\log_ax$};
	\draw[fill=black] (2,1) circle(1.5pt);
	\draw[dashed] (2,0)node[below]{\small$a^b$}--(2,1)--(0,1)node[above left]{\small$b$};
	\draw[color=red!60!black,thick] (-1,1)--(4,1) node[below]{$y=b$};
	\end{tikzpicture}"
},

new TikzItem2
{
    Id = 19,
    Title = "Đồ thị y = log_a x và y = b (0 < a < 1)",
    Category = "Mũ logarit",
    Description = "Đồ thị logarit với 0 < a < 1 cắt đường y = b tại x = a^b.",
    ImagePath = "Mu_logarit/mulogarit19.png",
    Code = @"\begin{tikzpicture}[smooth,samples=300,scale=0.8,>=stealth]
	\draw[->] (-1,0)--(4,0) node[below]{$x$};
	\draw[->] (0,-2.5)--(0,3) node[right]{$y$};
	\draw (0,0) node[below left]{$O$};
	\draw[dashed,black,domain=0.5:3.2]plot(\x,{ln((\x))/ln(0.5)})node[below right]{$y=\log_ax$};
	\draw[line width=0.8pt,black,domain=0.15:0.5]plot(\x,{ln((\x))/ln(0.5)});
	\draw[fill=black] (0.5,1) circle(1.5pt);
	\draw[dashed] (0.5,0)node[below]{\small$a^b$}--(0.5,1)--(0,1)node[above left]{\small$b$};
	\draw[color=red!60!black,thick] (-1,1)--(4,1) node[below]{$y=b$};
	\end{tikzpicture}"
},

new TikzItem2
{
    Id = 20,
    Title = "Đồ thị y = log₂ x và y = b",
    Category = "Mũ logarit",
    Description = "Đồ thị logarit cơ số 2 với đường y = b < 0, giao điểm tại x = 0.5.",
    ImagePath = "Mu_logarit/mulogarit20.png",
    Code = @"\begin{tikzpicture}[smooth,samples=300,scale=0.8,>=stealth]
			\draw[->] (-1,0)--(4,0) node[below]{$x$};
			\draw[->] (0,-2.5)--(0,2) node[right]{$y$};
			\draw (0,0) node[below left]{$O$};
			\draw[line width=0.8pt,color=violet,domain=0.2:3.2]plot(\x,{ln((\x))/ln(2)});
			\draw[fill=black] (1,0) circle(1.5pt) (2,1) circle(1.5pt) (0.5,-1) circle(1.5pt);
			\draw[dashed] (2,0)node[below]{\small$a$}--(2,1)--(0,1)node[left]{\small$1$};
			\draw[color=red!60!black] (-1,-1)--(4,-1) node[below]{$y=b$};
			\node[below] at (1.1,0) {\small$1$};
			\end{tikzpicture}"
},

new TikzItem2
{
    Id = 21,
    Title = "Đồ thị y = a^x với hai đường y = b",
    Category = "Mũ logarit",
    Description = "Đồ thị hàm mũ với a > 1 và hai đường thẳng y = b khác nhau.",
    ImagePath = "Mu_logarit/mulogarit21.png",
    Code = @"\begin{tikzpicture}[smooth,samples=300,scale=0.8,>=stealth]
		\draw[->] (-2,0)--(3,0) node[below]{$x$};
		\draw[->] (0,-2)--(0,4) node[right]{$y$};
		\draw (0,0) node[below left]{$O$};
		\draw[line width=1pt,color=blue,domain=-2:1.8] plot(\x,{2^(\x)});
		\draw[color=red!60!black,line width=1pt] (-2,2)--(3,2) node[below]{$y=b$};
		\draw[dashed,color=red!60!black] (-2,-1)--(3,-1) node[below]{$y=b$};
		\draw[dashed] (1,0)node[below]{\small$\log_ab$}--(1,2);
		\draw[fill=black](1,2) circle(2pt);
		\node[above] at (-2,0.3) {$y=a^x$};
		\node[left] at (0,2.35) {$b$};
		\node[left] at (0,1.15) {$1$};
		\end{tikzpicture}"
},

new TikzItem2
{
    Id = 22,
    Title = "Đồ thị y = log_a x, y = log_b x và y = log_c x",
    Category = "Mũ logarit",
    Description = "So sánh 3 đồ thị logarit với cơ số khác nhau: 0 < c < 1 < b < a.",
    ImagePath = "Mu_logarit/mulogarit22.png",
    Code = @"\begin{tikzpicture}[thick,>=stealth,x=1cm,y=0.9cm,scale=.8] 
		\draw[->] (-1,0) -- (4.5,0) node[below] {\small $x$};
		\draw[->] (0,-3) -- (0,3.7) node[right] {\small $y$};
		\foreach \x in {,,1,}
		\draw[thin,shift={(\x,0)}] (0pt,3pt)--(0pt,-3pt)node[below] {\footnotesize $\x$};
		\foreach \y in {,,,,,}
		\draw[thin,shift={(0,\y)}] (3pt,0pt)--(-3pt,0pt)node[right] {\footnotesize $\y$};
		\draw (0,0) node [below left] {\footnotesize $O$};
		\clip(-3,-2.4) rectangle (5,5);
		
		\draw [ line width = 1 pt, domain=0.09:3.1, samples=100]%
		plot(\x, {ln(\x)/ln(0.4)}) node[below]{\small $y=\log_c x$};
		
		\draw [line width = 1 pt, domain=0.09:3.1, samples=100]%
		plot(\x, {ln(\x)/ln(3)}) node[above]{\small $y=\log_b x$};
		
		\draw [ line width = 1 pt, domain=0.01:3.1, samples=200]%
		plot(\x, {ln(\x)/ln(1.4)}) node[above]{\small $y=\log_a x$};
		
		
		\end{tikzpicture}"
},

new TikzItem2
{
    Id = 23,
    Title = "Đồ thị y = a^x, y = b^x và y = c^x",
    Category = "Mũ logarit",
    Description = "So sánh 3 đồ thị hàm mũ: a > 1 > b > c > 0.",
    ImagePath = "Mu_logarit/mulogarit23.png",
    Code = @"\begin{tikzpicture}[>=stealth, scale=0.6]
		\draw[->,line width = 1pt] (-3,0)--(4,0) node[below]{$x$};
		\draw(0,0)node[below right]{$O$} circle (1pt);
		\draw(0,1)node[below left]{$1$} circle (1pt);
		\draw[->,line width = 1pt] (0,-1) --(0,5) node[below left]{$y$};
		\draw [black, thick, domain=-2:2.2] plot (\x, {2^\x})node[above]{$y=a^x$};
		\draw [black, thick, domain=-2.2:3] plot (\x, {(0.6)^\x});
		\draw (-4.5,2.7) node[above right]{$y=c^x$};
		\draw [black, thick, domain=-1.3:2] plot (\x, {(0.3)^\x});
		\draw (-1.5,4.7) node[above left]{$y=b^x$};
		\end{tikzpicture}"
},

new TikzItem2
{
    Id = 24,
    Title = "So sánh a, b, c từ đồ thị logarit",
    Category = "Mũ logarit",
    Description = "So sánh 3 cơ số a, b, c từ giao điểm của đồ thị logarit với y = 1: c < b < 1 < a.",
    ImagePath = "Mu_logarit/mulogarit24.png",
    Code = @"\begin{tikzpicture}[smooth,samples=300,scale=0.8,>=stealth]
			\draw[->] (-1,0)--(4,0) node[below]{$x$};
			\draw[->] (0,-2.5)--(0,3.5) node[right]{$y$};
			\draw (0,0) node[below left]{$O$};
			\draw[line width=0.8pt,color=violet,domain=0.15:4]plot(\x,{ln((\x))/ln(3)});
			\draw[line width=0.8pt,color=blue,domain=0.4:3.2]plot(\x,{ln((\x))/ln(1.5)});
			\draw[line width=0.8pt,color=orange,domain=0.2:3.2]plot(\x,{ln((\x))/ln(0.5)});
			\draw[fill=black] (1,0) circle(1.5pt) (0.5,1) circle(1.5pt) (1.5,1) circle(1.5pt) (3,1) circle(1.5pt);
			\draw[dashed] (0,1)node[left]{\small$1$}--(4,1)  (0.5,1)--(0.5,0)node[below]{\small$c$} (1.5,1)--(1.5,0)node[below]{\small$b$} (3,1)--(3,0)node[below]{\small$a$};
			\node[above] at (1,3.7) {\small \fbox{So sánh $a,b,c$}};
			\node[right] at (3,1.5) {\small$y=\log_ax$};
			\node[right] at (3,2.7) {\small$y=\log_bx$};
			\node[right] at (0.2,2.4) {\small$y=\log_cx$};
			\node[above] at (1,0) {\small$1$};
			\end{tikzpicture}"
},

new TikzItem2
{
    Id = 25,
    Title = "Đồ thị y = 2^x và y = log₂ x đối xứng qua y = x",
    Category = "Mũ logarit",
    Description = "Hai đồ thị hàm mũ và logarit cùng cơ số đối xứng qua đường thẳng y = x.",
    ImagePath = "Mu_logarit/mulogarit25.png",
    Code = @"\begin{tikzpicture}[smooth,samples=300,scale=0.8,>=stealth]
	\draw [color=gray!30,, xstep=1.0cm,ystep=1.0cm] (-2,-2.5) grid (4,3);
	\draw[->] (-2,0)--(4,0) node[below]{$x$};
	\draw[->] (0,-2.3)--(0,3) node[left]{$y$};
	\draw (0,0) node[below right]{$O$};
	\draw[line width=1.2pt,color=blue,domain=-2:1.5] plot(\x,{2^(\x)});
	\draw[line width=1.2pt,color=violet,domain=0.2:3.2]plot(\x,{ln((\x))/ln(2)});
	\draw[dashed,line width=0.7pt,color=orange] (-2,-2)--(3,3);
	\node[below] at (2,-1.2) {\small\fbox{Hình I.3}};
	\node[right] at (2.8,1) {\small\fbox{$y=\log_ax$}};
	\node[right] at (1.5,3) {\small\fbox{$y=a^x$}};
	\end{tikzpicture}"
},

new TikzItem2
{
    Id = 26,
    Title = "Đồ thị y = 2^x",
    Category = "Mũ logarit",
    Description = "Đồ thị hàm số mũ cơ số 2 qua (0,1) và (1,2).",
    ImagePath = "Mu_logarit/mulogarit26.png",
    Code = @"\begin{tikzpicture}[scale=0.7,>=stealth]
		\tkzDefPoints{0/0/O}
		\def \xmin{-3.1}
		\def \xmax{2.5}
		\def \ymin{-0.7}
		\def \ymax{3.5}
		\draw[->] (\xmin,0) -- (\xmax,0);
		\draw[->,color=black] (0,\ymin) -- (0,\ymax);
		\draw[color=black](\xmax-0.3,.2)node[right] {$x$};
		\draw[color=black] (.1,\ymax) node[right] {\normalsize $y$};
		\draw[color=black] (0pt,-8pt) node[left] {\small $O$};
		\begin{scope}
		\clip(\xmin ,\ymin) rectangle (\xmax-.3,\ymax-.3);
		%Vẽ đồ thị
		\draw[color=black,smooth,samples=100,domain=-4.08:4.06] 
		plot(\x,{2^(\x)});
		\end{scope}
		%vẽ râu ria
		\draw[dashed] (1,0)--(1,2)--(0,2);
		\node at (1,-.4){\small $ 1 $};
		\node at (-.3,2){\small $ 2 $};
		\node at (-.3,1.2){\small $ 1 $};
		\tkzDrawPoints[fill=black](O)
		\end{tikzpicture}"
},

new TikzItem2
{
    Id = 27,
    Title = "Đồ thị y = a^x và y = log_b x",
    Category = "Mũ logarit",
    Description = "Đồ thị hàm mũ với a > 1 và hàm logarit với 0 < b < 1.",
    ImagePath = "Mu_logarit/mulogarit27.png",
    Code = @"\begin{tikzpicture}[scale=0.7,>=stealth,x=1cm,y=1cm]
		\draw[->,line width = 1pt] (-1.6,0)--(0,0)%
		node[below right]{$O$}--(5,0) node[below]{$x$};
		\draw[->,line width = 1pt] (0,-1.5) --(0,3.5) node[right]{$y$};
		\draw [ line width = 1.2pt, domain=-1.6:3, samples=100]%
		plot (\x, {1.5^(\x)})node[above]{\footnotesize $y=a^x$};
		\draw[samples=100, smooth, domain=0.1:3] plot(\x,{ln((\x))/ln(0.5)})node[above right]{\footnotesize $y=\log_{b} x$};
		%\draw[fill=none] (0,0) circle(3pt);
		\end{tikzpicture}"
},

new TikzItem2
{
    Id = 28,
    Title = "Đồ thị y = log_a x với 0 < a < 1",
    Category = "Mũ logarit",
    Description = "Đồ thị logarit nghịch biến, qua (1,0) và (1/a, -1).",
    ImagePath = "Mu_logarit/mulogarit28.png",
    Code = @"\begin{tikzpicture}[smooth,samples=300,scale=0.8,>=stealth]
	\draw[->] (-1,0)--(4,0) node[below]{$x$};
	\draw[->] (0,-2)--(0,2.5) node[left]{$y$};
	\draw (0,0) node[below left]{$O$};
	\draw[line width=0.8pt,color=violet,domain=0.2:3.2]plot(\x,{ln((\x))/ln(0.5)});
	\draw[fill=black] (1,0) circle(1.5pt) (2,-1) circle(1.5pt);
	\draw[dashed] (2,0)node[above]{\small$\dfrac{1}{a}$}--(2,-1)--(0,-1)node[left]{\small$-1$};
	\node[below] at (1,-2.2) {\fbox{$0<a<1$}};
	\node[above] at (1.1,0) {\small$1$};
	\end{tikzpicture}"
},

new TikzItem2
{
    Id = 29,
    Title = "Đồ thị y = log_a x với a > 1",
    Category = "Mũ logarit",
    Description = "Đồ thị logarit đồng biến, qua (1,0) và (a,1).",
    ImagePath = "Mu_logarit/mulogarit29.png",
    Code = @"\begin{tikzpicture}[smooth,samples=300,scale=0.8,>=stealth]
	\draw[->] (-1,0)--(4,0) node[below]{$x$};
	\draw[->] (0,-2.5)--(0,2) node[right]{$y$};
	\draw (0,0) node[below left]{$O$};
	\draw[line width=0.8pt,color=violet,domain=0.2:3.2]plot(\x,{ln((\x))/ln(2)});
	\draw[fill=black] (1,0) circle(1.5pt) (2,1) circle(1.5pt);
	\draw[dashed] (2,0)node[below]{\small$a$}--(2,1)--(0,1)node[left]{\small$1$};
	\node[below] at (1,-2.6) {\fbox{$a>1$}};
	\node[below] at (1.1,0) {\small$1$};
	\end{tikzpicture}"
},

new TikzItem2
{
    Id = 30,
    Title = "So sánh a, b, c từ đồ thị hàm mũ",
    Category = "Mũ logarit",
    Description = "So sánh 3 cơ số từ giao điểm với x = 1: c < 1 < b < a.",
    ImagePath = "Mu_logarit/mulogarit30.png",
    Code = @"\begin{tikzpicture}[smooth,samples=300,scale=0.8,>=stealth]
		\draw[->] (-2,0)--(2,0) node[below]{$x$};
		\draw[->] (0,-0.5)--(0,4) node[right]{$y$};
		\draw (0,0) node[below left]{$O$};
		\draw[line width=0.8pt,color=blue,domain=-2:1.5] plot(\x,{2.5^(\x)});
		\draw[line width=0.8pt,color=violet,domain=-2:1.8] plot(\x,{1.7^(\x)});
		\draw[line width=0.8pt,color=orange,domain=-1.4:1.8] plot(\x,{0.4^(\x)});
		\draw[fill=black] (0,1) circle(1.5pt) (1,0.4) circle(1.5pt) (1,1.7) circle(1.5pt) (1,2.5) circle(1.5pt);
		\draw[dashed] (1,0)node[below]{\small$1$}--(1,4)  (1,0.4)--(0,0.4)node[left]{\small$c$} (1,1.7)--(0,1.7)node[left]{\small$b$} (1,2.5)--(0,2.5)node[left]{\small$a$};
		\node[below] at (0,-1) {\small \fbox{So sánh $a,b,c$}};
		\node[right] at (1.4,0.5) {\small$y=c^x$};
		\node[right] at (1.4,2) {\small$y=b^x$};
		\node[right] at (1.4,3.4) {\small$y=a^x$};
		\end{tikzpicture}"
},

new TikzItem2
{
    Id = 31,
    Title = "Đồ thị y = 0.5^x với 0 < a < 1",
    Category = "Mũ logarit",
    Description = "Đồ thị hàm mũ nghịch biến, qua (0,1) và (-1, 1/a).",
    ImagePath = "Mu_logarit/mulogarit31.png",
    Code = @"\begin{tikzpicture}[smooth,samples=300,scale=0.8,>=stealth]
	\draw[->] (-2,0)--(2.2,0) node[below]{$x$};
	\draw[->] (0,-0.5)--(0,4) node[right]{$y$};
	\draw (0,0) node[below right]{$O$};
	\draw[line width=1.2pt,color=orange,domain=-1.9:2] plot(\x,{0.5^(\x)});
	\draw[fill=black] (0,1) circle(1.5pt) (-1,2) circle(1.5pt);
	\draw[dashed] (-1,0)node[below]{\small$-1$}--(-1,2)--(0,2)node[right]{\small$\frac{1}{a}$};
	\node[below] at (0,-0.7) {\fbox{$0<a<1$}};
	\node[right] at (0,1.15) {$1$};
	\end{tikzpicture}"
},

new TikzItem2
{
    Id = 32,
    Title = "Đồ thị y = x^α với các α khác nhau",
    Category = "Mũ logarit",
    Description = "So sánh các hàm lũy thừa: α = 0, α = 1, α > 1, 0 < α < 1, và α < 0.",
    ImagePath = "Mu_logarit/mulogarit32.png",
    Code = @"\begin{tikzpicture}[thick,>=stealth,scale=0.7] 
		\draw[->,color=black] (0,0) -- (6.5,0);
		\draw[->,color=black] (0,0) -- (0.,5.5);
		\draw[color=black] (6.5,0) node[right] {\small $x$};
		\draw[color=black] (0,5.5) node[above] {\small $y$};
		\draw[color=black] (0,0) node[left] {\footnotesize $0$};
		\draw[line width=1.2pt,smooth,samples=100,domain=0:5] plot(\x,{(\x)^0}) node[above]{\scriptsize $\alpha =0$};
		\draw[line width=1.2pt,smooth,samples=100,domain=0:2.2] plot(\x,{(\x)^2})node[above right]{\scriptsize $\alpha >1$};
		\draw[line width=1.2pt,smooth,samples=100,domain=0.2:5] plot(\x,{(\x)^(-1)})node[above]{\scriptsize $\alpha <0$};
		\draw[line width=1.2pt,smooth,samples=100,domain=0:4] plot(\x,{(\x)^1})node[below right]{\scriptsize $\alpha =1$};
		\draw[line width=1.2pt,smooth,samples=100,domain=0:5] plot(\x,{(\x)^0.5})node[above]{\scriptsize $0<\alpha <1$};
	\end{tikzpicture}"
},

new TikzItem2
{
    Id = 33,
    Title = "Đồ thị y = x³, y = x² và y = x^(1/2)",
    Category = "Mũ logarit",
    Description = "So sánh 3 đồ thị lũy thừa: (1) y = x³, (2) y = x², (3) y = x^(1/2).",
    ImagePath = "Mu_logarit/mulogarit33.png",
    Code = @"\begin{tikzpicture}[>=stealth,scale=0.6, line join=round, line cap=round]
		\def\xmax{3.5} \def\ymax{5}
		\draw[->] (-0.1,0)--(\xmax,0) node [below]{$x$};
		\draw[->] (0,-0.1)--(0,\ymax) node [left]{$y$};
		\node at (0,0) [below left]{$O$};
		\clip (-0.9,-0.9) rectangle (\xmax-0.1,\ymax);
		\draw[smooth,samples=300,domain=0:\xmax] plot(\x,{(\x)^3});
		\draw[smooth,samples=300,domain=0:\xmax] plot(\x,{(\x)^2});
		\draw[smooth,samples=300,domain=0:\xmax] plot(\x,{(\x)^(0.5)});
		\draw[dashed] (1,0) node[below]{$1$}--(1,1)--(0,1)node[left]{$1$};
		\draw (2,1.42)node[below right]{$(3)$};
		\draw (2,4)node[above right]{$(2)$};
		\draw (1.7,4.9)node[below left]{$(1)$};
		\draw[fill=black] (1,1) circle(1.5pt);
		\end{tikzpicture}"
},

new TikzItem2
{
    Id = 34,
    Title = "Đồ thị y = x^a, y = x^b và y = x^c",
    Category = "Mũ logarit",
    Description = "So sánh 3 đồ thị lũy thừa: a < 0 < c < 1 < b.",
    ImagePath = "Mu_logarit/mulogarit34.png",
    Code = @"\begin{tikzpicture}[smooth,samples=300,scale=0.8,>=stealth]
	\draw[->] (-0.8,0)--(3.7,0) node[below]{$x$};
	\draw[->] (0,-0.5)--(0,4) node[right]{$y$};
	\draw (0,0) node[above left]{$O$};
	%\draw[domain=0:2.2] plot(\x,{(\x)^2});
	%\draw[domain=0:3] plot(\x,{(\x)});
	\draw[line width=1pt,color=red,smooth,samples=100,domain=0:3] plot(\x,{(\x)});
	\draw[line width=1pt,color=cyan,smooth,samples=100,domain=0:2] plot(\x,{(\x)^2});
	\draw[line width=1pt,color=violet,smooth,samples=100,domain=0.3:3] plot(\x,{(\x)^(-1)});
	\draw[fill=black] (1,1) circle(1.5pt);
	\draw[dashed] (1,0)node[below]{\small$1$}--(1,1)--(0,1)node[left]{\small$1$};
	\draw (2.7,0.6)node[right]{\small$y=x^a$};
	\draw (1.8,3.7)node[right]{\small$y=x^b$};
	\draw (2.5,2.5)node[right]{\small$y=x^c$};
	\end{tikzpicture}"
},

new TikzItem2
{
    Id = 35,
    Title = "Đồ thị y = 2^x với a > 1",
    Category = "Mũ logarit",
    Description = "Đồ thị hàm mũ đồng biến, qua (0,1) và (1,a).",
    ImagePath = "Mu_logarit/mulogarit35.png",
    Code = @"\begin{tikzpicture}[smooth,samples=300,scale=0.8,>=stealth]
	\draw[->] (-2,0)--(2,0) node[below]{$x$};
	\draw[->] (0,-0.5)--(0,4) node[right]{$y$};
	\draw (0,0) node[below left]{$O$};
	\draw[line width=1.2pt,color=blue,domain=-2:1.8] plot(\x,{2^(\x)});
	\draw[fill=black] (0,1) circle(1.5pt) (1,2) circle(1.5pt);
	\draw[dashed] (1,0)node[below]{\small$1$}--(1,2)--(0,2)node[left]{\small$a$};
	\node[below] at (0,-0.7) {\fbox{$a>1$}};
	\node[left] at (0,1.15) {$1$};
	\end{tikzpicture}"
},
