# パスワード

## パスワード管理の方法

ハッシュ化: データを規則性のない数値に変換する方法。元のデータを取り出せない
参考: http://viatmiena.hatenablog.com/entry/2015/12/01/011134

## RubyでSHA256を使ったハッシュ化

```
Digest::SHA256.hexdigest 'hoge'
=> "ecb666d778725ec97307044d642bf4d160aabb76f56c0069c71ea25b1e926825"
```

## ログイン時にパスワードを要求する

自身のパスワードを設定する

```
User.find('vitamin').update(password: Digest::SHA256.hexdigest('hogehoge'))
```

## ログインページを変更

app/views/logins/new.html.erbを変更

```erb
<h1>ログイン</h1>

<% if flash[:alert] %>
  <div style="background-color: #FF5555;">
    <%=flash[:alert]  %>
  </div>
<% end %>

<%= form_tag login_path do %>
  <div>
    <%= label_tag :account, 'アカウント名' %>
    <%= text_field_tag :account, params[:account] %>
  </div>

  <div>
    <%= label_tag :password, 'パスワード' %>
    <%= password_field_tag :password, params[:password] %>
  </div>

  <%= submit_tag 'ログイン' %>
<% end %>
```

## ログイン処理を変更

app/controllers/logins_controller.rb

```
def create
  user = User.find_by(account: params[:account])
  return redirect_to new_login_path, alert: 'ユーザが存在しないか、パスワードが違います' if user.nil? || user.password != Digest::SHA256.hexdigest(params[:password])
  session[:user_id] = user.id
  redirect_to users_path
end
```

## ユーザの新規作成と編集ページでパスワードを設定する

演習1.
