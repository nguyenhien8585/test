
new TikzItem2
{
    Id = 1,
    Title = "Đồ thị hàm số Parabol với tiếp tuyến",
    Category = "Liên tục - không liên tục",
    Description = "Đồ thị hàm số y=f(x) dạng parabol với điểm tiếp xúc M(x₀,y₀) và tiếp tuyến Δ.",
    ImagePath = "Lien_tuc_-_khong_lien_tuc/lientuc_khonglientuc_1.png",
    Code = @"\begin{tikzpicture}[smooth,samples=300,scale=0.8,y=0.6cm,>=stealth,font=\footnotesize]
	\draw[->] (-0.8,0)--(6,0) node[below]{$x$};
	\draw[->] (0,-0.5)--(0,7.5) node[right]{$y$};
	\draw (0,0) node[above left]{$O$};
	\draw[line width=0.7pt,domain=0.4:5.5,blue] plot(\x,{0.5*(\x-2)^2+1})node[above]{$y=f(x)$};
	\draw[line width=0.4pt,domain=1.8:5.5] plot(\x,{2*(\x)-4.5});
	\draw[line width=0.7pt,domain=2.1:5.5,red] plot(\x,{(\x)-1.5})node[below right]{$\Delta$};
	\draw[fill=black] (3,1.5) circle(1.5pt) (5,5.5) circle(1.5pt);
	\draw[dashed] (3,0)node[below]{$x_0$}--(3,1.5)node[above]{$M$}--(0,1.5)node[left]{$y_0$};
	%\node[right] at (2,2.4) {$2$};
	\end{tikzpicture}"
},

new TikzItem2
{
    Id = 2,
    Title = "Hàm số liên tục từng khúc (Parabol và đường thẳng)",
    Category = "Liên tục - không liên tục",
    Description = "Đồ thị hàm số gồm hai phần: parabol trên đoạn [-1.2, 1] và đường thẳng trên đoạn [1, 3], liên tục tại x=1.",
    ImagePath = "Lien_tuc_-_khong_lien_tuc/lientuc_khonglientuc_2.png",
    Code = @"\begin{tikzpicture}[smooth,samples=300,scale=0.6,>=stealth,font=\footnotesize]
			\draw[->] (-2,0)--(3.5,0) node[below]{$x$};
			\draw[->] (0,-1)--(0,4) node[right]{$y$};
			\draw (0,0) node[below left]{$O$};
			\draw[line width=0.7pt,domain=-1.2:1,magenta] plot(\x,{2*(\x)^2+1});
			\draw[line width=0.7pt,domain=1:3,magenta] plot(\x,{(\x)-1});
			\draw[fill=black] (1,3) circle(1.5pt) (1,0) circle(1.5pt) (0,1) circle(1.5pt) (2,1) circle(1.5pt);
			\draw[dashed] (1,0)node[below]{$1$}--(1,3)--(0,3)node[left]{$3$}
							(2,0)node[below]{$2$}--(2,1)--(0,1)node[below left]{$1$};
	\end{tikzpicture}"
},

new TikzItem2
{
    Id = 3,
    Title = "Hàm số có nhiều điểm gián đoạn",
    Category = "Liên tục - không liên tục",
    Description = "Đồ thị hàm số gồm parabol và các đoạn thẳng, có điểm gián đoạn tại x=-3, x=-1 và x=2.",
    ImagePath = "Lien_tuc_-_khong_lien_tuc/lientuc_khonglientuc_3.png",
    Code = @"\begin{tikzpicture}[smooth,samples=300,scale=0.5,>=stealth,font=\footnotesize]
			\draw[->] (-5,0)--(5,0) node[below]{$x$};
			\draw[->] (0,-0.9)--(0,4.8) node[right]{$y$};
			\draw (0,0) node[below right]{$O$};
			\draw[line width=0.7pt,domain=-1:2,magenta] plot(\x,{-(\x)^2+4});
			\draw[line width=0.7pt,magenta] (-4,1)--(-3,3)--(-1,2) (2,0)--(4,3) node[above]{$y=f(x)$};
			\draw[magenta,fill=magenta] (-3,3) circle(1.5pt) (-1,2) circle(1.5pt) (-1,3) circle(1.5pt) (2,0) circle(1.5pt);
			\draw[dashed] (-1,0)node[below]{$-1$}--(-1,3) (-3,0)node[below]{$-3$}--(-3,3);
			\node[below] at (2,0) {$2$};
	\end{tikzpicture}"
},

new TikzItem2
{
    Id = 4,
    Title = "Đồ thị hàm số bậc ba có cực trị",
    Category = "Liên tục - không liên tục",
    Description = "Đồ thị hàm số y=x³-3x²+2, có điểm cực tiểu tại (2, -2).",
    ImagePath = "Lien_tuc_-_khong_lien_tuc/lientuc_khonglientuc_4.png",
    Code = @"\begin{tikzpicture}[smooth,samples=300,scale=0.4,>=stealth,font=\footnotesize]
			\draw[->] (-2,0)--(4,0) node[below]{$x$};
			\draw[->] (0,-2.2)--(0,3) node[right]{$y$};
			\draw (0,0) node[below right]{$O$};
			\draw[line width=0.7pt,domain=-1:3,magenta] plot(\x,{(\x)^3-3*(\x)^2+2});
			\draw[fill=black] (2,-2) circle(1.5pt);
			\draw[dashed] (2,0)node[above]{$2$}--(2,-2)--(0,-2);
	\end{tikzpicture}"
},

new TikzItem2
{
    Id = 5,
    Title = "Hàm số gián đoạn tại điểm (Parabol-Tuyến tính)",
    Category = "Liên tục - không liên tục",
    Description = "Đồ thị hàm số gián đoạn tại x=1, gồm parabol y=-x²+3 và đường thẳng y=x.",
    ImagePath = "Lien_tuc_-_khong_lien_tuc/lientuc_khonglientuc_5.png",
    Code = @"\begin{tikzpicture}[smooth,samples=300,scale=0.8,>=stealth,font=\footnotesize]
			\draw[->] (-2.5,0)--(3.5,0) node[below]{$x$};
			\draw[->] (0,-0.5)--(0,4) node[right]{$y$};
			\draw (0,0) node[above left]{$O$};
			\draw[line width=0.7pt,domain=-1.8:1] plot(\x,{-(\x)^2+3});
			\draw[line width=0.7pt,domain=1:3] plot(\x,{(\x)});
			\draw[fill=black] (3,3) circle(1pt) (1,1) circle(1pt) (1,2) circle(1pt);
			\draw[dashed] (1,0)node[below]{$1$}--(1,2)--(0,2)node[left]{$2$}
			(3,0)node[below]{$3$}--(3,3)--(0,3)node[above left]{$3$}
			(1,1)--(0,1)node[left]{$1$};
	\end{tikzpicture}"
},

new TikzItem2
{
    Id = 6,
    Title = "Đồ thị Parabol có cực tiểu",
    Category = "Liên tục - không liên tục",
    Description = "Đồ thị hàm số y=x²-4x+3, parabol có đỉnh tại điểm (2, -1).",
    ImagePath = "Lien_tuc_-_khong_lien_tuc/lientuc_khonglientuc_6.png",
    Code = @"\begin{tikzpicture}[smooth,samples=300,scale=0.4,>=stealth,font=\footnotesize]
			\draw[->] (-0.8,0)--(4.5,0) node[below]{$x$};
			\draw[->] (0,-1.5)--(0,2.5) node[right]{$y$};
			\draw (0,0) node[above left]{$O$};
			\draw[line width=0.7pt,domain=0.3:3.7,magenta] plot(\x,{(\x)^2-4*(\x)+3});
			\draw[fill=black] (2,-1) circle(1.5pt);
			\draw[dashed] (2,0)node[above]{$2$}--(2,-1)--(0,-1);
	\end{tikzpicture}"
},

new TikzItem2
{
    Id = 7,
    Title = "Hàm số gián đoạn (Parabol và đường thẳng rời rạc)",
    Category = "Liên tục - không liên tục",
    Description = "Đồ thị hàm số gián đoạn gồm parabol y=x²-4x+3 trên [-0.8, 2] và đường thẳng y=2x-6 trên [3, 4].",
    ImagePath = "Lien_tuc_-_khong_lien_tuc/lientuc_khonglientuc_7.png",
    Code = @"\begin{tikzpicture}[smooth,samples=300,scale=0.4,>=stealth,font=\footnotesize]
			\draw[->] (-0.8,0)--(4.5,0) node[below]{$x$};
			\draw[->] (0,-1.5)--(0,2.5) node[right]{$y$};
			\draw (0,0) node[above left]{$O$};
			\draw[line width=0.7pt,domain=0.3:2,magenta] plot(\x,{(\x)^2-4*(\x)+3});
			\draw[line width=0.7pt,domain=3:4,magenta] plot(\x,{2*(\x)-6});
			\draw[fill=black] (2,-1) circle(1.5pt);
			\draw[dashed] (2,0)node[above]{$2$}--(2,-1)--(0,-1);
	\end{tikzpicture}"
},

new TikzItem2
{
    Id = 8,
    Title = "Hàm số liên tục từng khúc tại điểm (2, -1)",
    Category = "Liên tục - không liên tục",
    Description = "Đồ thị hàm số liên tục gồm parabol y=x²-4x+3 và đường thẳng y=2x-5, liên tục tại x=2.",
    ImagePath = "Lien_tuc_-_khong_lien_tuc/lientuc_khonglientuc_8.png",
    Code = @"\begin{tikzpicture}[smooth,samples=300,scale=0.4,>=stealth,font=\footnotesize]
			\draw[->] (-0.8,0)--(4.5,0) node[below]{$x$};
			\draw[->] (0,-1.5)--(0,3) node[right]{$y$};
			\draw (0,0) node[above left]{$O$};
			\draw[line width=0.7pt,domain=0.3:2,magenta] plot(\x,{(\x)^2-4*(\x)+3});
			\draw[line width=0.7pt,domain=2:4,magenta] plot(\x,{2*(\x)-5});
			\draw[fill=black] (2,-1) circle(1.5pt);
			\draw[dashed] (2,0)node[above]{$2$}--(2,-1)--(0,-1);
	\end{tikzpicture}"
},

new TikzItem2
{
    Id = 9,
    Title = "Hàm số gián đoạn tại x=1",
    Category = "Liên tục - không liên tục",
    Description = "Đồ thị hàm số gián đoạn tại x=1, gồm parabol y=-x²+3 và đường thẳng y=x.",
    ImagePath = "Lien_tuc_-_khong_lien_tuc/lientuc_khonglientuc_9.png",
    Code = @"\begin{tikzpicture}[smooth,samples=300,scale=0.8,>=stealth,font=\footnotesize]
		\draw[->] (-2.5,0)--(3.5,0) node[below]{$x$};
		\draw[->] (0,-0.5)--(0,4) node[right]{$y$};
		\draw (0,0) node[above left]{$O$};
		\draw[line width=0.7pt,domain=-1.8:1] plot(\x,{-(\x)^2+3});
		\draw[line width=0.7pt,domain=1:3] plot(\x,{(\x)});
		\draw[fill=black] (3,3) circle(1pt) (1,1) circle(1pt) (1,2) circle(1pt);
		\draw[dashed] (1,0)node[below]{$1$}--(1,2)--(0,2)node[left]{$2$}
		(3,0)node[below]{$3$}--(3,3)--(0,3)node[above left]{$3$}
		(1,1)--(0,1)node[left]{$1$};
		\end{tikzpicture}"
},

new TikzItem2
{
    Id = 10,
    Title = "Hàm số liên tục từng khúc (Tuyến tính và Bậc ba)",
    Category = "Liên tục - không liên tục",
    Description = "Đồ thị hàm số gồm đường thẳng y=1-x trên [-2.5, 1] và hàm bậc ba y=x²(x-3) trên [1, 4], liên tục tại x=1.",
    ImagePath = "Lien_tuc_-_khong_lien_tuc/lientuc_khonglientuc_10.png",
    Code = @"\begin{tikzpicture}[line width=1.0pt, >=stealth, scale=0.45]
		\draw[->] (-2.7,0) -- (4.5,0) node [below] {\scriptsize $x$};
		\foreach \x/\xtext in {}
		\draw[shift={(\x,0)}] (0pt,2pt) -- (0pt,-2pt) node[below] {\scriptsize $\xtext$};
		\foreach \y/\ytext in {}
		\draw[shift={(0,\y)}] (2pt,0) -- (-2pt,0) node[left] {\scriptsize $\ytext$};
		\draw[->] (0,-4.5) -- (0,4.5) node [left] {\scriptsize $y$};
		\draw (0,0) node [below left] {\scriptsize $O$}; 
		\draw[dashed](1,0)--(1,-2)--(0,-2) (2,0)--(2,-4)--(0,-4);
		\clip (-2.7,-4.5) rectangle (4.5,4);
		\draw[line width=1pt,smooth,samples=100,domain=-2.5:1] plot(\x,{1-\x});
		\draw[line width=1pt,smooth,samples=100,domain=1:4] plot(\x,{(\x)*(\x)*(\x-3)});
		\draw (1,0) node[above]{\scriptsize $1$} (2,0) node[above]{\scriptsize $2$} (-1,0) circle(1.5pt) node[above] {\scriptsize $-1$} (0,-2) node[left]{\scriptsize $-2$} (0,-4) node[left]{\scriptsize $-4$};
		\end{tikzpicture}"
},

new TikzItem2
{
    Id = 11,
    Title = "Đồ thị hàm số bậc ba trên đoạn [a, b]",
    Category = "Liên tục - không liên tục",
    Description = "Đồ thị hàm số y=x³-x²-x trên đoạn [a, b] với a=-1, b=2.",
    ImagePath = "Lien_tuc_-_khong_lien_tuc/lientuc_khonglientuc_11.png",
    Code = @"\begin{tikzpicture}[scale=0.6,thick,>=stealth, x=1.0cm,y=1.0cm]
				\draw [->] (-1.5,0)--(3,0)node[below]{\footnotesize $x$};
				\draw [->] (0,-1.2)--(0,2)node[right]{\footnotesize $y$};
				\draw [fill=white,draw=black] (0,0) circle (1pt)node[above right] {\footnotesize $O$};
				\draw [dashed](-1,0)node[above]{$a$}--(-1,-1) (2,0)node[below]{$b$}--(2,2);
				\clip(-2,-1.2) rectangle (2,2);
				\draw[line width=1.0pt,smooth,samples=100,domain=-1:2]  plot(\x,{(\x)^3-(\x)^2-(\x)});
		\end{tikzpicture}"
},

new TikzItem2
{
    Id = 12,
    Title = "Hàm số gián đoạn tại x₀ (Parabol dịch chuyển)",
    Category = "Liên tục - không liên tục",
    Description = "Đồ thị hàm số parabol bị gián đoạn tại x=x₀ do bị dịch chuyển theo phương thẳng đứng, minh họa định nghĩa hàm số gián đoạn.",
    ImagePath = "Lien_tuc_-_khong_lien_tuc/lientuc_khonglientuc_12.png",
    Code = @"\begin{tikzpicture}[smooth,samples=300,scale=0.8,>=stealth,font=\footnotesize]
		\draw[->] (-0.8,0)--(4.7,0) node[below]{$x$};
		\draw[->] (0,-1.5)--(0,3.5) node[right]{$y$};
		\draw (0,0) node[above left]{$O$};
		\draw[line width=0.7pt,domain=0.3:1] plot(\x,{-(\x)^2+4*(\x)-2});
		\draw[line width=0.7pt,domain=1:4] plot(\x,{-(\x)^2+4*(\x)-1})node[below right]{$y=f(x)$};
		\draw[fill=black] (1,2) circle(1pt);
		\draw[dashed] (0,2)node[left]{$y_0$}--(1,2)--(1,0)node[below]{$x_0$};
		\node[right] at (0,-2) {Hàm số gián đoạn tại $x_0$};
	\end{tikzpicture}"
},

new TikzItem2
{
    Id = 13,
    Title = "Hàm số tuyến tính liên tục từng khúc",
    Category = "Liên tục - không liên tục",
    Description = "Đồ thị hàm số tuyến tính liên tục, gồm hai đoạn thẳng nối liền nhau tại x=0 và x=2.",
    ImagePath = "Lien_tuc_-_khong_lien_tuc/lientuc_khonglientuc_13.png",
    Code = @"\begin{tikzpicture}[smooth,samples=300,scale=0.8,>=stealth,font=\footnotesize]
		\draw[->] (-2.8,0)--(3.7,0) node[below]{$x$};
		\draw[->] (0,-1.5)--(0,2.8) node[right]{$y$};
		\draw (-2,2)--(0,2) node[above right]{$2$}--(3,-1);
		\draw (0,0) node[above left]{$O$};
		\draw[fill=black] (-2,2) circle(1.5pt) (0,2) circle(1.5pt) (2,0) circle(1.5pt) (3,-1) circle(1.5pt);
		\draw[dashed] (-2,0)node[below]{$-2$}--(-2,2) (3,0)node[above]{$3$}--(3,-1)--(0,-1)node[left]{$-1$};
		\node[above right] at (2,0) {$2$};
		\end{tikzpicture}"
},

new TikzItem2
{
    Id = 14,
    Title = "Hàm số tuyến tính có đoạn hằng và đoạn nghiêng",
    Category = "Liên tục - không liên tục",
    Description = "Đồ thị hàm số gồm đoạn ngang AB từ (-1, 2) đến (4, 2) và đoạn nghiêng BC từ (4, 2) đến (6, -2), gián đoạn tại x=5.",
    ImagePath = "Lien_tuc_-_khong_lien_tuc/lientuc_khonglientuc_14.png",
    Code = @"\begin{tikzpicture}[smooth,samples=300,scale=0.8,>=stealth,font=\footnotesize]
		\draw[->] (-1.7,0)--(7,0) node[below]{$x$};
		\draw[->] (0,-2.5)--(0,2.8) node[right]{$y$};
		\draw (0,0) node[below right]{$O$};
		\draw[fill=black] (-1,2) circle(1.5pt) (4,2) circle(1.5pt) (5,0) circle(1.5pt) (6,-2) circle(1.5pt);
		\draw (-1,2) node[above]{$A$}--(4,2) node[above right]{$B$}--(6,-2);
		\draw[dashed] 
		(-1,0)node[below]{$-1$}--(-1,2)
		(4,0)node[below]{$4$}--(4,2)
		(6,0)node[above]{$6$}--(6,-2)node[right]{$C$}--(0,-2)node[left]{$-2$};
		\node[above] at (5.2,0) {$5$};
		\node[right] at (0,2.2) {$2$};
	\end{tikzpicture}"
},

new TikzItem2
{
    Id = 15,
    Title = "Hàm số liên tục tại x₀ (Parabol)",
    Category = "Liên tục - không liên tục",
    Description = "Đồ thị hàm số parabol y=-x²+4x-2 liên tục tại x=x₀, minh họa định nghĩa hàm số liên tục tại một điểm.",
    ImagePath = "Lien_tuc_-_khong_lien_tuc/lientuc_khonglientuc_15.png",
    Code = @"\begin{tikzpicture}[smooth,samples=300,scale=0.8,>=stealth,font=\footnotesize]
		\draw[->] (-0.8,0)--(4.7,0) node[below]{$x$};
		\draw[->] (0,-1.5)--(0,2.5) node[right]{$y$};
		\draw (0,0) node[above left]{$O$};
		\draw[line width=0.7pt,domain=0.3:3.7] plot(\x,{-(\x)^2+4*(\x)-2})node[below]{$y=f(x)$};
		\draw[fill=black] (1,1) circle(1pt);
		\draw[dashed] (1,1)--(1,0)node[below]{$x_0$};
		\node[right] at (0,-2) {Hàm số liên tục tại $x_0$};
	\end{tikzpicture}"
},

new TikzItem2
{
    Id = 16,
    Title = "Hàm số gián đoạn tại x₀ (Parabol có lỗ hổng)",
    Category = "Liên tục - không liên tục",
    Description = "Đồ thị hàm số parabol y=-x²+4x-2 bị gián đoạn tại x=x₀ do bị loại bỏ giá trị tại điểm (x₀, y₀), minh họa hàm số gián đoạn loại bỏ.",
    ImagePath = "Lien_tuc_-_khong_lien_tuc/lientuc_khonglientuc_16.png",
    Code = @"\begin{tikzpicture}[smooth,samples=300,scale=0.8,>=stealth,font=\footnotesize]
		\draw[->] (-0.8,0)--(4.7,0) node[below]{$x$};
		\draw[->] (0,-1.5)--(0,2.5) node[right]{$y$};
		\draw (0,0) node[above left]{$O$};
		\draw[line width=0.7pt,domain=0.3:1,->] plot(\x,{-(\x)^2+4*(\x)-2});
		\draw[line width=0.7pt,domain=3.7:1.01,->] plot(\x,{-(\x)^2+4*(\x)-2});
		\draw[fill=black] (1,1.8) circle(1pt);
		\draw[dashed] (0,1.8)node[left]{$y_0$}--(1,1.8)--(1,0)node[below]{$x_0$};
		\node[right] at (3.7,-1) {$y=f(x)$};
		\node[right] at (0,-2) {Hàm số gián đoạn tại $x_0$};
	\end{tikzpicture}"
},

new TikzItem2
{
    Id = 17,
    Title = "Hàm số gián đoạn (Hai Parabol rời nhau)",
    Category = "Liên tục - không liên tục",
    Description = "Đồ thị hàm số gồm hai nhánh parabol gián đoạn tại x=2, nhánh trái y=-2.5x²+5.5x và nhánh phải y=x²-4x+5.",
    ImagePath = "Lien_tuc_-_khong_lien_tuc/lientuc_khonglientuc_17.png",
    Code = @"\begin{tikzpicture}[>=stealth, scale= 0.5,samples=100,smooth,color=black,line width=0.6pt,xscale=1,yscale=1]
  \draw[->] (-1,0) -- (5,0) node[below] { $x$};
  \draw[->] (0,-1) -- (0,6) node[below right] {$y$};
  \draw (0,0) node[below right] {\footnotesize $O$};
  \draw[thick,line width=0.4pt,domain=-0.133:2] plot(\x,{-2.5*(\x)^2+5.5*(\x)});
  \draw[thick,line width=0.4pt,domain=2:4.1423] plot(\x,{(\x)^2-4*(\x)+5}); 
  \draw[dashed] (1,0)--(1,3)--(0,3) (2,0)--(2,1)--(0,1) (4,0)--(4,5)--(0,5);
  \draw (1,0) node[below]{\small $1$} (2,0) node[below]{\small$2$} (4,0) node[below]{\small$4$} 
  (0,1) node[left]{\small$1$} (0,3) node[left]{\small$3$} (0,5) node[left]{\small$5$};
  \fill (2,1) circle (1.5pt); \fill (1,3) circle (1.5pt); \fill (4,5) circle (1.5pt); 
  \end{tikzpicture}"
},

new TikzItem2
{
    Id = 18,
    Title = "Đồ thị hàm số hữu tỉ đơn giản",
    Category = "Liên tục - không liên tục",
    Description = "Đồ thị hàm số hữu tỉ y=(2x-1)/(4x-3) trên đoạn [1, 4].",
    ImagePath = "Lien_tuc_-_khong_lien_tuc/lientuc_khonglientuc_18.png",
    Code = @"\begin{tikzpicture}[>=stealth,x=1cm,y=1cm]
  \draw[->,line width = 0.7pt] (-0.5,0)--(0,0)%
  node[below right]{$O$}--(4,0) node[below]{$x$};
  \draw[->,line width = 0.7pt] (0,-0.5) --(0,3) node[right]{$y$};
  \foreach \x in {1}{
   \draw (\x,0) node[below]{\footnotesize $\x$} circle (1pt);%Ox
  }
  \foreach \y in {}{
   \draw (0,\y) node[left]{$\y$} circle (1pt);%Oy
  }
  \draw[thick,samples=100,domain=1:4] plot (\x,{(2*\x-1)/(4*\x-3)});
  \draw[dashed] (1,0)--(1,1);
  \end{tikzpicture}"
},

new TikzItem2
{
    Id = 19,
    Title = "Hàm số đồng biến nghiêm ngặt (Parabol ngược)",
    Category = "Liên tục - không liên tục",
    Description = "Đồ thị parabol ngược y=-0.1x²+2.5 minh họa hàm số đồng biến nghiêm ngặt với hai điểm f(x₁) > f(x₂) khi x₁ < x₂.",
    ImagePath = "Lien_tuc_-_khong_lien_tuc/lientuc_khonglientuc_19.png",
    Code = @"\begin{tikzpicture}[>=stealth,scale=0.6]
 \draw[->] (-1,0)--(0,0)%
 node[below left]{$O$}--(5,0) node[below]{$x$};
 \draw[->] (0,-1) --(0,3) node[right]{$y$};
 \draw [red, thick, domain=0.2:4, samples=100] %
 plot (\x, {-0.1*(\x)^2+2.5});
 \draw [dashed] (1,0)node[below]{\footnotesize$x_1$} --(1,2.4)--(0,2.4)node[left]{\footnotesize$f(x_1)$};
 \draw [dashed] (3,0)node[below]{\footnotesize$x_2$} --(3,1.6)--(0,1.6)node[left]{\footnotesize$f(x_2)$};
 \draw[fill=blue] (1,2.4) circle(2pt);
 \draw[fill=blue] (3,1.6) circle(2pt);
 \end{tikzpicture}"
},

new TikzItem2
{
    Id = 20,
    Title = "Hàm số đồng biến (Parabol thuận)",
    Category = "Liên tục - không liên tục",
    Description = "Đồ thị parabol y=0.1x²+1 minh họa hàm số đồng biến với hai điểm f(x₁) < f(x₂) khi x₁ < x₂.",
    ImagePath = "Lien_tuc_-_khong_lien_tuc/lientuc_khonglientuc_20.png",
    Code = @"\begin{tikzpicture}[>=stealth,scale=0.6]
 \draw[->] (-1,0)--(0,0)%
 node[below left]{$O$}--(5,0) node[below]{$x$};
 \draw[->] (0,-1) --(0,3) node[right]{$y$};
 \draw [black,thick, domain=0.2:4, samples=100] %
 plot (\x, {0.1*(\x)^2+1});
 \draw [dashed] (1,0)node[below]{\footnotesize$x_1$} --(1,1.1)--(0,1.1)node[left]{\footnotesize$f(x_1)$};
 \draw [dashed] (3,0)node[below]{\footnotesize$x_2$} --(3,1.9)--(0,1.9)node[left]{\footnotesize$f(x_2)$};
 \draw[fill=blue] (1,1.1) circle(2pt);
 \draw[fill=blue] (3,1.9) circle(2pt);
 \end{tikzpicture}"
},

new TikzItem2
{
    Id = 21,
    Title = "Hàm số giá trị tuyệt đối (Hình 2)",
    Category = "Liên tục - không liên tục",
    Description = "Đồ thị hàm số y=2|x+1| với đỉnh tại x=-2, minh họa hàm số có chứa giá trị tuyệt đối.",
    ImagePath = "Lien_tuc_-_khong_lien_tuc/lientuc_khonglientuc_21.png",
    Code = @"\begin{tikzpicture}[scale=0.5,>=stealth]
\draw[->,line width = 1pt] (0,0) node[below left]{$O$}--(2,0) node[below]{$x$};
\draw[-,line width = 1pt](-3,0)--(0,0);
\draw[->,line width = 1pt] (0,0) --(0,4) node[right]{$y$};
\draw[-,line width = 1pt](0,-1)--(0,0);
%diem tren do thi
\draw (-2,0) node[below left]{$-2$} circle (1pt);
%ve dothi
\draw [thick, domain=-3:-1] plot (\x, {-2*(\x+1)});
\draw [thick, domain=-1:1] plot (\x, {2*(\x+1)});
\draw [dashed] (-2,0)--(-2,2)--(0,2) node[right]{$2$} circle(1pt);
\draw (0,-1) node[right]{$\text{Hình 2}$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 22,
    Title = "Hàm số giá trị tuyệt đối đơn giản (Hình 3)",
    Category = "Liên tục - không liên tục",
    Description = "Đồ thị hàm số y=2|x| với đỉnh tại gốc tọa độ, dạng V cân đối qua trục y.",
    ImagePath = "Lien_tuc_-_khong_lien_tuc/lientuc_khonglientuc_22.png",
    Code = @"\begin{tikzpicture}[scale=0.5,>=stealth]
\draw[->,line width = 1pt] (0,0) node[below left]{$O$}--(2,0) node[below]{$x$};
\draw[-,line width = 1pt](-3,0)--(0,0);
\draw[->,line width = 1pt] (0,0) --(0,4) node[right]{$y$};
\draw[-,line width = 1pt](0,-1)--(0,0);
%diem tren do thi
\draw (-2,0) node[below left]{$-2$} circle (1pt);
%ve dothi
\draw [thick, domain=-2:0] plot (\x, {-2*\x});
\draw [thick, domain=0:2] plot (\x, {2*\x});
\draw [dashed] (-1,0)--(-1,2)--(0,2) node[right]{$2$} circle(1pt);
\draw (0,-1) node[right]{$\text{Hình 3}$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 23,
    Title = "Hàm số giá trị tuyệt đối (Dạng mái nhà)",
    Category = "Liên tục - không liên tục",
    Description = "Đồ thị hàm số y=1-|x|, dạng mái nhà với đỉnh tại (0, 1) và cắt trục x tại x=±1.",
    ImagePath = "Lien_tuc_-_khong_lien_tuc/lientuc_khonglientuc_23.png",
    Code = @"\begin{tikzpicture}[scale=1][>=stealth,x=1cm,y=1cm]
\clip (-2,-1.5) rectangle (2.2,2.2);
\draw[->] (-2,0)--(0,0)node[below left]{$O$}--(2,0) node[below]{$x$};
\draw[->] (0,-1.5) --(0,2) node[right]{$y$};
\draw plot[domain=-2:0, samples=100] (\x, {\x+1});
\draw plot[domain=0:2, samples=100] (\x, {-\x+1});
\draw (-1,0)node[below=5pt]{$-1$};
\draw (1,0)node[below=5pt]{$1$};
\draw (0,1)node[above left]{$1$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 24,
    Title = "Hàm số nghịch biến (Parabol ngược)",
    Category = "Liên tục - không liên tục",
    Description = "Đồ thị parabol ngược y=-0.1x²+2.5 minh họa hàm số nghịch biến với hai điểm f(x₁) > f(x₂).",
    ImagePath = "Lien_tuc_-_khong_lien_tuc/lientuc_khonglientuc_24.png",
    Code = @"\begin{tikzpicture}[>=stealth,scale=0.6]
\draw[->] (-1,0)--(0,0)%
node[below left]{$O$}--(5,0) node[below]{$x$};
\draw[->] (0,-1) --(0,3) node[right]{$y$};
\draw [thick, domain=0.2:4, samples=100] %
plot (\x, {-0.1*(\x)^2+2.5});
\draw [dashed] (1,0)node[below]{\footnotesize$x_1$} --(1,2.4)--(0,2.4)node[left]{\footnotesize$f(x_1)$};
\draw [dashed] (3,0)node[below]{\footnotesize$x_2$} --(3,1.6)--(0,1.6)node[left]{\footnotesize$f(x_2)$};
\draw[fill=blue] (1,2.4) circle(2pt);
\draw[fill=blue] (3,1.6) circle(2pt);
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 25,
    Title = "Hàm số giá trị tuyệt đối ngược (Hình 1)",
    Category = "Liên tục - không liên tục",
    Description = "Đồ thị hàm số y=-2|x+1| với đỉnh tại x=-2, dạng V ngược xuống.",
    ImagePath = "Lien_tuc_-_khong_lien_tuc/lientuc_khonglientuc_25.png",
    Code = @"\begin{tikzpicture}[scale=0.5,>=stealth]
\draw[->,line width = 1pt] (0,0) node[below left]{$O$}--(2,0) node[below]{$x$};
\draw[-,line width = 1pt](-3,0)--(0,0);
\draw[->,line width = 1pt] (0,0) --(0,1) node[right]{$y$};
\draw[-,line width = 1pt](0,-4)--(0,0);
%diem tren do thi
\draw (-2,0) node[below left]{$-2$} circle (1pt);
%ve dothi
\draw [thick, domain=-3:-1] plot (\x, {2*(\x+1)});
\draw [thick, domain=-1:1] plot (\x, {-2*(\x+1)});
\draw [dashed] (-2,0)--(-2,-2)--(0,-2) node[right]{$-2$} circle(1pt);
\draw (-2,-4) node[right]{$\text{Hình 1}$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 26,
    Title = "Hàm số giá trị tuyệt đối trên lưới",
    Category = "Liên tục - không liên tục",
    Description = "Đồ thị hàm số y=2-|x| trên lưới tọa độ, dạng mái nhà với đỉnh tại (0, 2).",
    ImagePath = "Lien_tuc_-_khong_lien_tuc/lientuc_khonglientuc_26.png",
    Code = @"\begin{tikzpicture}[>=stealth,x=1cm,y=1cm,scale=0.5]
\draw[black!30!,dashed] (-4,-2) grid (3,3);
\draw[->,line width = 1pt] (-4,0)--(0,0)%
node[below right]{$O$}--(4,0) node[above]{$x$};
\draw[->,line width = 1pt] (0,-1) --(0,3) node[below right]{$y$};
\draw [line width = 1.2pt]%
plot[domain=-3.5:0, samples=100] (\x, \x+2);
\draw [line width = 1.2pt]%
plot[domain=0:3.5, samples=100] (\x, -\x+2); %
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 27,
    Title = "Hàm số Parabol kết hợp đoạn ngang",
    Category = "Liên tục - không liên tục",
    Description = "Đồ thị hàm số gồm parabol y=-x²+2 trên [-1.8, 1] và đoạn ngang y=1 trên [1, 4], liên tục tại x=1.",
    ImagePath = "Lien_tuc_-_khong_lien_tuc/lientuc_khonglientuc_27.png",
    Code = @"\begin{tikzpicture}[smooth,samples=300,scale=0.6,>=stealth]
\draw[black!30!,dashed] (-2,-1.5) grid (4,3);
\draw[->] (-2,0)--(5,0) node[below]{$x$};
\draw[->] (0,-1.5)--(0,3) node[right]{$y$};
\foreach \x in {1,2,3,4}{
\draw (\x,0) node[below]{$\x$};%Ox
}
\foreach \y in {1}{
\draw (0,\y) node[left]{$\y$};%Oy
}
\draw (0,0) node[below left]{$O$};
\draw[domain=-1.8:1,blue,thick] plot(\x,{-(\x)^2+2});
\draw [blue,thick](1,1)--(4,1) node[above]{\small $y=f(x)$};
\draw[fill=black] (0,2) circle(1.5pt) (1,1) circle(1pt);
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 28,
    Title = "Hàm số y=2|x|-1",
    Category = "Liên tục - không liên tục",
    Description = "Đồ thị hàm số y=2|x|-1, dạng V với đỉnh tại (0, -1), cắt trục x tại x=±0.5.",
    ImagePath = "Lien_tuc_-_khong_lien_tuc/lientuc_khonglientuc_28.png",
    Code = @"\begin{tikzpicture}[scale=0.6,line width=1pt,>=stealth,x=1cm,y=1cm]
\draw (-0.3,0) node[above] {\footnotesize $O$};
\draw[->] (-3,0) -- (3,0) node [below left] {\footnotesize$x$};
\draw[->] (0,-2) -- (0,4) node [below right] {\footnotesize$y$};
\foreach \x/\xtext in {1/1}
\draw[shift={(\x,0)}] (0pt,2pt)--(0pt,-2pt) node[below] {\footnotesize $\xtext$};
\foreach \y/\ytext in {-1/-1}
\draw[shift={(0,\y)}] (2pt,0pt)--(-2pt,0pt) node[left] {\footnotesize $\ytext$};
\clip (-2.95,-1.95) rectangle (2.95,3.95);
\draw[smooth,samples=100,domain=-3:3] plot(\x,{2*abs(\x)-1});
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 29,
    Title = "Hàm số y=|x+1| có điểm rỗng",
    Category = "Liên tục - không liên tục",
    Description = "Đồ thị hàm số y=|x+1| với điểm loại bỏ tại x=-1, gián đoạn loại bỏ tại điểm đỉnh.",
    ImagePath = "Lien_tuc_-_khong_lien_tuc/lientuc_khonglientuc_29.png",
    Code = @"\begin{tikzpicture}[scale=0.8]
\draw[->] (-3.2,0) -- (1.2,0) node[below] {$x$};
\draw[->] (0,-0.6) -- (0,2.2) node[right] {$y$};
\node at (0,0) [below left] {\footnotesize $O$};
\draw [domain=-3:1, thick, black,color=blue] plot (\x, {abs((\x)+1)} );
\fill[fill=white,draw=black]
(-1,0) circle (1pt);
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 30,
    Title = "Đường thẳng qua gốc tọa độ y=x-1",
    Category = "Liên tục - không liên tục",
    Description = "Đồ thị hàm số tuyến tính y=x-1 có điểm đặc biệt tại gốc tọa độ, cắt trục x tại (1, 0) và trục y tại (0, -1).",
    ImagePath = "Lien_tuc_-_khong_lien_tuc/lientuc_khonglientuc_30.png",
    Code = @"\begin{tikzpicture}[scale=0.5]
\draw [->] (-3.2,0) -- (5.2,0) node [below]{$ x $};
\draw [->] (0,-3.2) -- (0,4) node [left]{$ y $};
\node (0,0) [below left] {$ O $};
\node at (1,0) [above] {$1$};
\node at (0,-1) [right] {$-1$};
\draw [thick, color=blue, domain=-2:4] plot (\x, {\x-1});
\fill (0,0) circle (2.5pt);
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 31,
    Title = "Hàm số tuyến tính liên tục ba khúc",
    Category = "Liên tục - không liên tục",
    Description = "Đồ thị hàm số liên tục gồm ba đoạn thẳng: y=-x-2 trên (-∞, -2], y=x+2 trên [-2, 0] và y=-3x+2 trên [0, +∞).",
    ImagePath = "Lien_tuc_-_khong_lien_tuc/lientuc_khonglientuc_31.png",
    Code = @"\begin{tikzpicture}[line cap=round,line join=round,>=stealth,x=1.0cm,y=1.0cm, scale=0.6]
\draw[->,color=black] (-5,0.) -- (3,0.);
\foreach \x in {-2}
\draw[shift={(\x,0)},color=black] (0pt,2pt) -- (0pt,-2pt) node[below] {\footnotesize $\x$};
\draw[->,color=black] (0.,-2) -- (0.,3);
\foreach \y in {2}
\draw[shift={(0,\y)},color=black] (2pt,0pt) -- (-2pt,0pt) node[left] {\footnotesize $\y$};
\draw[color=black] (0pt,-10pt) node[left] {\footnotesize $0$};
\clip(-5,-2) rectangle (3,3);
\draw[line width=1.0pt,color=black,smooth,samples=100,domain=-5:-2] plot(\x,{-1*(\x)-2});
\draw[line width=1.0pt,color=black,smooth,samples=100,domain=-2:0] plot(\x,{(\x)+2});
\draw[line width=1.0pt,color=black,smooth,samples=100,domain=0:3] plot(\x,{-3*(\x)+2});
\draw (2.7, 0.3) node {$x$}; \draw (0.3,2.5) node {$y$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 32,
    Title = "Hàm số gấp khúc liên tục 4 điểm",
    Category = "Liên tục - không liên tục",
    Description = "Đồ thị hàm số gấp khúc liên tục đi qua 4 điểm: (-3, -1), (-1, 1), (1, 0) và (3, 4).",
    ImagePath = "Lien_tuc_-_khong_lien_tuc/lientuc_khonglientuc_32.png",
    Code = @"\begin{tikzpicture}[smooth,samples=300,scale=0.8,>=stealth]
\draw[->] (-3.5,0)--(3.5,0) node[below]{$x$};
\draw[->] (0,-1.5)--(0,4.5) node[right]{$y$};
\draw (0,0) node[below right]{\footnotesize$O$};
\draw[fill=black] (-3,-1) circle(1.5pt) (-1,1) circle(1.5pt) (1,0) circle(1.5pt) (3,4) circle(1.5pt);
\draw[thick] (-3,-1)--(-1,1)--(1,0)--(3,4);
\draw[dashed] (-3,0)node[above]{\footnotesize$-3$}--(-3,-1)--(0,-1)node[right]{\footnotesize$-1$}
(-1,0)node[below]{\footnotesize$-1$}--(-1,1)--(0,1)node[right]{\footnotesize$1$}
(3,0)node[below]{\footnotesize$3$}--(3,4)--(0,4)node[left]{\footnotesize$4$};
\node[below] at (1,0) {\footnotesize$1$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 33,
    Title = "Hàm số Parabol kết hợp đường thẳng nghịch",
    Category = "Liên tục - không liên tục",
    Description = "Đồ thị hàm số gồm parabol y=(x+1)²-1 trên [-3, 1] và đường thẳng y=-x+4 trên [1, 4.5], liên tục tại x=1.",
    ImagePath = "Lien_tuc_-_khong_lien_tuc/lientuc_khonglientuc_33.png",
    Code = @"\begin{tikzpicture}[smooth,samples=300,scale=0.75,>=stealth]
\draw[color=gray!60!white,line width=0.07pt,dashed] (-3.5,-1.5) grid (5.5,3.5);
\draw[->] (-3.5,0)--(5.5,0) node[below]{$x$};
\draw[->] (0,-1.5)--(0,3.5) node[right]{$y$};
\foreach \x in {-3,-2,-1,1,2,3,4}{
\draw (\x,0) node[below]{\footnotesize $\x$};%Ox
}
\foreach \y in {-1,1,2,3}{
\draw (0,\y) node[left]{\footnotesize $\y$};%Oy
}
\draw (0,0) node[below right]{\small $O$};
\draw[line width=1.2pt, color=blue,domain=-3:1] plot(\x,{(\x+1)^2-1});
\draw[line width=1.2pt, color=blue,domain=1:4.5] plot(\x,{-(\x)+4});
%\node[right] at (0.5,-2) {\fbox{$a>0$}};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 34,
    Title = "Đồ thị hàm số bậc ba y=x³-3x",
    Category = "Liên tục - không liên tục",
    Description = "Đồ thị hàm số bậc ba y=x³-3x trên lưới tọa độ, có 2 điểm cực trị.",
    ImagePath = "Lien_tuc_-_khong_lien_tuc/lientuc_khonglientuc_34.png",
    Code = @"\begin{tikzpicture}[smooth,samples=300,scale=0.6,>=stealth]
\draw[color=gray!60!white,line width=0.07pt,dashed] (-2,-2) grid (2,2);
\draw[->] (-2,0)--(2,0) node[below]{$x$};
\draw[->] (0,-2)--(0,2) node[right]{$y$};
\draw (0,0) node[above left]{$O$};
\draw[line width=1.2pt, color=blue,domain=-2:2] plot(\x,{(\x)^3-3*(\x)});
\node[right] at (0,1.2) {\small $1$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 35,
    Title = "Đồ thị hàm số bậc hai y=x²-1",
    Category = "Liên tục - không liên tục",
    Description = "Đồ thị parabol y=x²-1 trên lưới tọa độ, có đỉnh tại (0, -1), cắt trục x tại x=±1.",
    ImagePath = "Lien_tuc_-_khong_lien_tuc/lientuc_khonglientuc_35.png",
    Code = @"\begin{tikzpicture}[smooth,samples=300,scale=0.6,>=stealth]
\draw[color=gray!60!white,line width=0.07pt,dashed] (-2,-2) grid (2,2);
\draw[->] (-2,0)--(2,0) node[below]{$x$};
\draw[->] (0,-2)--(0,2) node[right]{$y$};
\draw (0,0) node[above left]{$O$};
\draw[line width=1.2pt, color=blue,domain=-1.5:1.5] plot(\x,{(\x)^2-1});
\node[right] at (0,-1.2) {\small $1$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 36,
    Title = "Đồ thị hàm số căn bậc hai y=√x",
    Category = "Liên tục - không liên tục",
    Description = "Đồ thị hàm số căn bậc hai y=√x trên lưới tọa độ, xác định trên [0, +∞), đi qua điểm (1, 1).",
    ImagePath = "Lien_tuc_-_khong_lien_tuc/lientuc_khonglientuc_36.png",
    Code = @"\begin{tikzpicture}[smooth,samples=300,scale=0.6,>=stealth]
\draw[color=gray!60!white,line width=0.07pt,dashed] (-1,-1) grid (3,3);
\draw[->] (-1,0)--(3,0) node[below]{$x$};
\draw[->] (0,-1)--(0,3) node[right]{$y$};
\draw (0,0) node[below left]{$O$};
\draw[line width=1.2pt, color=blue,domain=0:3] plot(\x,{(\x)^0.5});
\node[below] at (1.1,0) {\small $1$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 37,
    Title = "Hàm số đồng biến y=0.1x²+1",
    Category = "Liên tục - không liên tục",
    Description = "Đồ thị parabol y=0.1x²+1 minh họa tính đồng biến với hai điểm x₁, x₂ và giá trị f(x₁), f(x₂).",
    ImagePath = "Lien_tuc_-_khong_lien_tuc/lientuc_khonglientuc_37.png",
    Code = @"\begin{tikzpicture}[>=stealth,scale=0.7]
\draw[->] (-1,0)--(0,0)%
node[below left]{$O$}--(5,0) node[below]{$x$};
\draw[->] (0,-1) --(0,3) node[right]{$y$};
\draw [black,thick, domain=0.2:4, samples=100] %
plot (\x, {0.1*(\x)^2+1});
\draw [dashed] (1,0)node[below]{\footnotesize$x_1$} --(1,1.1)--(0,1.1)node[left]{\footnotesize$f(x_1)$};
\draw [dashed] (3,0)node[below]{\footnotesize$x_2$} --(3,1.9)--(0,1.9)node[left]{\footnotesize$f(x_2)$};
\draw[fill=blue] (1,1.1) circle(2pt);
\draw[fill=blue] (3,1.9) circle(2pt);
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 38,
    Title = "Hàm số nghịch biến y=-0.1x²+2.5",
    Category = "Liên tục - không liên tục",
    Description = "Đồ thị parabol ngược y=-0.1x²+2.5 minh họa tính nghịch biến với hai điểm x₁, x₂ và giá trị f(x₁), f(x₂).",
    ImagePath = "Lien_tuc_-_khong_lien_tuc/lientuc_khonglientuc_38.png",
    Code = @"\begin{tikzpicture}[>=stealth,scale=0.7]
\draw[->] (-1,0)--(0,0)%
node[below left]{$O$}--(5,0) node[below]{$x$};
\draw[->] (0,-1) --(0,3) node[right]{$y$};
\draw [red, thick, domain=0.2:4, samples=100] %
plot (\x, {-0.1*(\x)^2+2.5});
\draw [dashed] (1,0)node[below]{\footnotesize$x_1$} --(1,2.4)--(0,2.4)node[left]{\footnotesize$f(x_1)$};
\draw [dashed] (3,0)node[below]{\footnotesize$x_2$} --(3,1.6)--(0,1.6)node[left]{\footnotesize$f(x_2)$};
\draw[fill=blue] (1,2.4) circle(2pt);
\draw[fill=blue] (3,1.6) circle(2pt);
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 39,
    Title = "Đồ thị hàm số y=|x|",
    Category = "Liên tục - không liên tục",
    Description = "Đồ thị hàm số giá trị tuyệt đối y=|x|, dạng V với đỉnh tại gốc tọa độ, đối xứng qua trục y.",
    ImagePath = "Lien_tuc_-_khong_lien_tuc/lientuc_khonglientuc_39.png",
    Code = @"\begin{tikzpicture}[>=stealth,scale=0.7]
\draw[->] (-3,0)--(0,0)%
node[below left]{$O$}--(3,0) node[below]{$x$};
\draw[->] (0,-1) --(0,2.5) node[right]{$y$};
\draw[blue, line width=1pt] (-2,2) --(0,0)--(2,2);
\node at (2,1.5) [below]{\footnotesize$y=|x|$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 40,
    Title = "Hàm số gián đoạn (Hàm bậc ba và tuyến tính)",
    Category = "Liên tục - không liên tục",
    Description = "Đồ thị hàm số gián đoạn tại x=0, gồm hàm bậc ba y=x³ trên [-1.25, 0] và đường thẳng y=x trên [0, 2].",
    ImagePath = "Lien_tuc_-_khong_lien_tuc/lientuc_khonglientuc_40.png",
    Code = @"\begin{tikzpicture}[smooth,samples=300,scale=0.6,>=stealth]
\draw[color=gray!60!white,line width=0.07pt,dashed] (-2,-2) grid (2,2);
\draw[->] (-2,0)--(2,0) node[below]{$x$};
\draw[->] (0,-2)--(0,2) node[right]{$y$};
\draw (0,0) node[below right]{$O$};
\draw[line width=1.2pt, color=blue,domain=-1.25:0] plot(\x,{(\x)^3});
\draw[line width=1.2pt,color=blue,domain=0:2] plot(\x,{(\x)});
\node[left] at (0,1.1) {\small $1$};
\end{tikzpicture}"
},

