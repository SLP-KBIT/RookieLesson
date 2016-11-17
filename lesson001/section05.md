# パイプ

## パイプとは

あるコマンドの実行結果を、他のコマンドに受け渡す処理または記号( **"|"** )
```
$ ps aux | grep root
root       346  0.0  0.0  51576  1928 ?        Ss    9月11   5:52 /lib/systemd/systemd-udevd --daemon
syslog     959  0.0  0.0 256032  9732 ?        Ssl   9月11   1:15 rsyslogd
message+   984  0.0  0.0  39312  1548 ?        Ss    9月11   1:48 dbus-daemon --system --fork
root      1045  0.0  0.0  43444  1872 ?        Ss    9月11   0:00 /lib/systemd/systemd-logind
vitamin  19082  0.0  0.0  11416   920 pts/21   S+   20:27   0:00 grep sys
```