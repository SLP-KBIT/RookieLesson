# ユーザの削除機能の実装

削除に関するアクション
```
destroy : 指定されたIDのデータを削除する
```

destroyへのPrefixは、`user_path(:id or Userインスタンス)`の`delete`メソッドである。

## ユーザ一覧に削除ボタンを追加

index.html.erbの一覧表`<tbody>`の中身を以下のように変更。

```
<% @users.each do |user| %>
  <td><%= user.id %></td>
  <td><%= user.account %></td>
  <td><%= link_to '編集', edit_user_path(user) %></td>
  <td><%= link_to '削除', user_path(user), method: 'delete' %></td>
<% end %>
```

## destroyのアクションを作成

app/controllers/users_controller.rbにアクションを追加する
送信されたIDのデータを削除した後、ユーザ一覧ページへリダイレクトさせる。

```
def update
  user = User.find(params[:id])
  user.delete
  redirect_to users_path
end
```

## 確認ダイアログを表示する

削除時に、すぐに削除してしまうと、誤操作の危険がある。
削除ボタンを押した際に、ダイアログで確認を行うことで、簡単な誤操作を防ぐことができる。
`link_to`メソッドに `data: { confirm: '~' }`と指定することで、移動前に指定したテキストのダイアログを表示し、OKを押したときだけ遷移するようにすることが出来る。

```
<%= link_to '削除', user_path(user), method: 'delete', data: { confirm: "#{user.account}を削除してよろしいですか？" } %>
```
