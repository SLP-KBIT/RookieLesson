## コントローラの作成

```
bundle exec rails g controller users
```

## ルーティングの設定

### ルーティングとは

サーバのURLとControllerのアクションを紐付けること。

```
/users/1 #=> users_controller#show(1)
```

### ルーティングの設定

config/routes.rb に記述

```
Rails.application.routes.draw do
  resources :users # 追加
  # resources =
  #   index
  #   new
  #   create
  #   show
  #   edit
  #   update
  #   destroy
end
```

### ルーティングの確認

```
$ bundle exec rake routes

Prefix    Verb   URI Pattern               Controller#Action
users     GET    /users(.:format)          users#index
          POST   /users(.:format)          users#create
new_user  GET    /users/new(.:format)      users#new
edit_user GET    /users/:id/edit(.:format) users#edit
user      GET    /users/:id(.:format)      users#show
          PATCH  /users/:id(.:format)      users#update
          PUT    /users/:id(.:format)      users#update
          DELETE /users/:id(.:format)      users#destroy
```

## ユーザ一覧(indexアクション)の作成

### Controllerにアクションを追加

app/controllers/users_controller.rbにindexメソッドを追加。

```
class UsersController < ApplicationController
  def index
    @users = User.all
  end
end
```

`@`付きの変数は、View側から参照が可能

### Viewを追加

app/views/users/index.html.erbを作成

```
<h1>ユーザ一覧</h1>
<table>                                                                                                            <thead>
    <th>ID</th>
    <th>名前</th>
  </thead>
  <tbody>
    <% @users.each do |user| %>
      <td><%= user.id %></td>
      <td><%= user.account %></td>
    <% end %>
  </tbody>
</table>
```


---
