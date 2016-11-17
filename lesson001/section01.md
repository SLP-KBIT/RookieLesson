# Shellとは

## kernel

OSの中核となる部分。
アプリケーションとハードウェアレベルでの実際のデータ処理との架け橋となる。  
ex. プロセス管理、メモリ管理、デバイス管理、etc...

## Shell

ユーザとkernelの間のやり取りを仲介するプログラム。
ユーザからの入力を、kernelに分かる形(機械語)に変換して伝え、kernelからの応答をユーザにわかる形に変換して表示する。
ユーザから見て、kernelを殻(shell)のように包んでいることからShellと呼ぶ。  
CUIの形態をとるコマンドラインシェルとCUIの形態をとるグラフィカルシェルがある。

![kernel_and_shell](./elements/section01/kernel.png)  
(引用: http://www.cc.kyoto-su.ac.jp/~hirai/text/shell.html)

## Shellへの命令

コマンドラインシェルにおいて、shellへの命令は**コマンド**を用いて行う。
(コマンドの実体は、実行ファイルである。)
