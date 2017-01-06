# ユーザの新規作成・編集ページの作成

## 新規作成

新規作成に関するアクション
```
new    : 新規作成の入力フォームのページ
create : 実際にデータを作るアクション
```

### UserControllerへアクションを追加

```
def new
  @user = User.new
end

def create
end
```

### newのViewを追加

app/views/users/new.html.erbを作成
Viewヘルパー`form_for`を利用する。`form_for`の引数として、空のモデルインスタンス(`User.new`)を作成すると、自動で`/users`への`POST`リクエストを送るformを作成してくれる

※ Viewヘルパー: Viewを簡単に生成するためのRailsの機能

```
<h1>ユーザ新規作成</h1>

<%= form_for @user do |f| %>
  <%= f.label :account, 'アカウント名' %>
  <%= f.text_field :account %>
  <br />

  <%= f.submit '作成' %>
<% end %>
```

### createのアクションを作成

Controller側では、送信されたパラメータを`params`変数で取得できる。
送信されたパラメータでDBにデータを作成した後、ユーザ一覧ページへリダイレクトさせる。

```
def create
  user = params['user']
  User.create(account: user['account'])
  redirect_to users_path
end
```

### indexからnewへのリンクの作成

index.html.erbの任意の場所に以下を追加

```
<%= link_to '新規作成', new_user_path %>
```

## 編集

編集に関するアクション
```
edit   : 編集の入力フォームのページ
update : 実際にデータを更新するアクション
```

### UserControllerへアクションを追加

edit, update, destroy, showでは、ユーザを一意に特定するために、`id`をURLに埋め込んでいる。
`params[:id]`で参照ができる。

```
def edit
  @user = User.find(params[:id])
end

def update
end
```

### editのViewを追加

app/views/users/edit.html.erbを作成
Viewヘルパー`form_for`を利用する。`form_for`の引数として、既存のモデルインスタンス(`User.find(id)`)を作成すると、自動で`/users/:id`への`PUT or PATCH`リクエストを送るformを作成してくれる

```
<h1>ユーザ新規作成</h1>

<%= form_for @user do |f| %>
  <%= f.label :account, 'アカウント名' %>
  <%= f.text_field :account %>
  <br />

  <%= f.submit '作成' %>
<% end %>
```

### createのアクションを作成

送信されたパラメータでDBを更新した後、ユーザ一覧ページへリダイレクトさせる。

```
def update
  user = User.find(params[:id])
  user_params = params['user']
  User.update(account: user_params['account'])
  redirect_to users_path
end
```

### indexからnewへのリンクの作成

index.html.erbの一覧表`<tbody>`の中身を以下のように変更

```
<% @users.each do |user| %>
  <td><%= user.id %></td>
  <td><%= user.account %></td>
  <td><%= link_to '編集', edit_user_path(user) %></td>
<% end %>
```

## 部分テンプレートの作成

newとeditで利用している`form_for`以降は、ほとんど同一の内容である。
同じViewを書く必要があるような場合は、その部分を共通化したほうが、管理・開発の上で都合が良い。
**部分テンプレート**を利用することで、別ファイルのViewを埋め込むことが出来る。
部分テンプレートで挿入されるファイルは`_`から始める必要がある。
まず、フォームをテンプレート化した`_form.html.erb`を作成する。

```
<%= form_for @user do |f| %>
  <%= f.label :account, 'アカウント名' %>
  <%= f.text_field :account %>
  <br />

  <%= f.submit '作成' %>
<% end %>
```

部分テンプレートを挿入する場合は、以下のようにして利用する

```
<%= render partial: 'form' %>
```

また、送信ボタンに表示するテキストは、`new`と`edit`で異なる。
このような場合、部分テンプレートに`locals`オプションで引数を渡すことが出来る。

```
<%= render partial: 'form', locals: {sumbit_text: '送信'} %>
```

_form.html.erbの以下の部分を変更する。

```
  <%= f.submit submit_text %>
```

---

次: [ユーザの削除機能の追加](./section03.md)
