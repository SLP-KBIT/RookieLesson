# 管理者専用のページを作る

ユーザの編集、新規、削除は管理者権限が無いと操作できないようにする

## ユーザに管理者権限を追加

`bundle exec rails g migration AddColumnToUser is_admin:boolean`

```ruby
class AddColumnToUser < ActiveRecord::Migration[5.0]
  def change
    add_column :users, :is_admin, :boolean, default: false, nil: false
  end
end
```

自分のユーザに管理者権限を付与しておく
```
User.find_by(account: 'vitamin').update(is_admin: true)
```

## 管理者権限チェック用のメソッドを追加

```ruby|app/models/user.rb
def admin?
  is_admin
end
```

## ApplicationControllerに管理者権限チェック用の処理を定義

```ruby
  def authenticate_admin!
    user = session[:user_id] && User.find_by(id: session[:user_id])
    raise ActionController::RoutingError.new('Not Found') unless user.present? && user.admin?
  end
```

## UseControllerに管理者権限のチェックを追加


```
before_action :authenticate_admin!, only: [:new, :create, :edit, :update]
```
