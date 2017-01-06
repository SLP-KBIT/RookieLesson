# ログイン機能を実装する

## ログイン機能の仕組み

セッション機能を利用して、ログイン状態を保持する。

### セッションとは

HTTPでは、リクエストに対するレスポンスを返す一度のやり取りしか行うことが出来ない。
そのため、状態を持つことが出来ない(ステートレス・プロトコル、Stateless Protocol)。
セッションとは、HTTP通信に状態を持たせるための仕組みである。
セッションの実現には、Cookieを用いる。

### Cookieとは

Cookieは、Webブラウザにパラメータを持たせる仕組み。
名前と値の組をCookieに保存し、HTTPのリクエストヘッダに含めて送信する。
```
ex. name=vitamin; password=hogehoge;
```

### Cookieの問題点

Cookieは、Webブラウザに状態を持たせるため、ユーザ側で書き換えることが出来てしまう。

### Sessionとは

サーバ側で、アクセスの情報を保持する仕組み。
サーバ側が値を持つため、ユーザ側で書き換えることは不可能。
CookieにセッションのIDを持たせ、それを基にSessionの値へアクセスする。

```
// Cookie(ブラウザ側)
SESSIONID=abcdefghijklmn

// Session(サーバ側)
ID=abcdefghijklmn;
name=vitamin;
password=hogehoge;
```

## Controllerの作成

```
bundle exec rails g controller logins
```

## Viewの作成

```app/views/login/new.html.erb
<h1>ログイン</h1>

<% if flash[:alert] %>
  <div style="background-color: #FF5555;">
    <%=flash[:alert]  %>
  </div>
<% end %>

<%= form_tag login_path do %>
  <%= label_tag :account, 'アカウント名' %>
  <%= text_field_tag :account, params[:account] %>
  <%= submit_tag 'ログイン' %>
<% end %>
```

※ flash : Railsにおける簡易通知の仕組み。一度表示すると中身が消える。alert、notice等がある

## createアクションの実装

```app/controllers/logins_controller.rb
def create
  # アカウント名でユーザを検索
  user = User.find_by(account: params[:account])
  # ユーザがいない場合、警告とともにログインページへリダイレクト
  return redirect_to new_login_path, alert: 'ユーザが存在しません' if user.nil?
  # ユーザがいた場合は、ユーザIDをセッションに格納
  session[:user_id] = user.id
  # ログイン後のページへ遷移
  redirect_to users_path
end
```

## ログインユーザを表示する

```app/views/users/index.html.erb
<h1>Logined by <%= User.find(session[:user_id]).account %></h1>
```

---

次: [ログインを必須にする](./section02.md)
