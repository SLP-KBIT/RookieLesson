# RSpec入門

## 参考文献

- [使えるRSpec入門・その1「RSpecの基本的な構文や便利な機能を理解する」](http://qiita.com/jnchito/items/42193d066bd61c740612#describe--it--expect-%E3%81%AE%E5%BD%B9%E5%89%B2%E3%82%92%E7%90%86%E8%A7%A3%E3%81%99%E3%82%8B)
- [使えるRSpec入門・その1「RSpecの基本的な構文や便利な機能を理解する」](http://qiita.com/jnchito/items/2e79a1abe7cd8214caa5#%E3%81%9D%E3%82%82%E3%81%9D%E3%82%82%E3%83%9E%E3%83%83%E3%83%81%E3%83%A3%E3%81%A3%E3%81%A6%E4%BD%95)
## RSpecとは

Ruby用のテストフレームワーク。
テスト内容をRubyのコードで記述し、自動化することが出来る。
独特な記法が多く、慣れが必要

## RSpecの導入

### インストール

Gemfileに以下を記述

```Ruby
group :test do
  gem 'rspec-rails'
end
```

```
$ bundle install
$ bundle exec rails g rspec:install
      create  .rspec
      create  spec
      create  spec/spec_helper.rb
      create  spec/rails_helper.rb
```

実行確認

```
$ bundle exec rspec 
No examples found.


Finished in 0.00024 seconds (files took 0.02848 seconds to load)
0 examples, 0 failures
```

### 各種ファイルの説明

- .rspec : rspecのオプションなどを設定
- spec/ : テストファイルを設置するディレクトリ
- spec/spec_helper.rb : RSpecの全般に関する設定ファイル
- spec/rails_helper.rb :  RailsにおけるRSpecの設定ファイル。中でspec_helper.rbをrequireしている

### .rspecを編集する

デフォルトでは`spec_helper.rb`をrequireしているため、`rails_helper.rb`をrequireするように変更

```
--color
--require rails_helper
```

## テストを記述してみる

テストファイルを作成する。
**\*_spec.rbという名前で作成しないと、テストファイルであると認識してくれないので注意する。**

```
mkdir spec/sample/
[emacs|vim] spec/sample/sample_spec.rb
```

### 成功するテスト

以下のコードを記述する

```ruby
describe 'Sample' do
  it '変数Numが1のとき2で割ったあまりは1' do
    num = 1
    expect(num % 2).to eq 1
  end
end
```

実行してみよう

### 失敗するテスト

```ruby
describe 'Sample' do
  it '変数Numが1のとき2で割ったあまりは0' do
    num = 1
    expect(num % 2).to eq 0
  end
end
```

※ `--format documentation`オプションを利用するのが個人的なおすすめ。お好みで`.rspec`に記述しよう。

## RSpecの文法(超基礎)

### describe 

テストのグループ化に関する宣言。中に複数のテストを記述することが可能。
ネストすることも可能

```ruby
describe 'Userに関するテスト' do
    describe 'パスワードに関するテスト' do
    end
    describe 'アカウント名に関するテスト' do
    end
end
```

### it 

1つのテストのまとまり。この中に記述されているものが実行される。

```ruby
describe 'Userに関するテスト' do
    it 'Userが作れる' do
    	   
    end
end
```

### expectとマッチャ

マッチャとは、値が特定の条件に一致するかを確認するもの。テストの本体。
expectはマッチャを呼び出すためのメソッド。`to`または`not_to`メソッドを続けて呼び、マッチャに続ける。
様々な条件を簡単に記述できる。

```ruby
expect(1 + 2).to eq 3
expect(1 + 2).not_to eq 2

expect(1+2).to be > 3
expect([]).to be_empty
expect(User.new).to be_valid
```

## RSpecの文法(ちょっと発展)

### context

describeと同じくテストのグループ化に関する宣言。テストが条件によって異なるとき、こちらで記述する。テストの可読性を上げるための構文。

```ruby
describe 'Userに関するテスト' do
    context 'アカウント名が重複していないとき' do
        it do 
            ユーザが作れる
        end
    end
    
    context 'アカウント名が重複していないとき' do
        it do
            ユーザが作れない
        end
    end
end
```

### before

テストの共通処理を記述する。スコープ内のexampleの実行のたびに、before内の処理が実行される

```ruby
describe 'User'
   describe 'アカウント名に関するテスト' do
        before do
            'vitamin'ユーザを作成する
        end

        context 'アカウント名が重複していないとき' do
            it do 
                ユーザが作れる
            end
        end

        context 'アカウント名が重複していないとき' do
            it do
                ユーザが作れない
            end
        end
    end
    
    describe 'パスワードに関するテスト' do
        # ここでは beforeは実行されない
    end
end
```

## 最初のテストを書き直してみる

```ruby
describe 'Sample' do                                                                                                          
  describe '2で割ったあまりは、変数Numが' do                                                                                  
    context '1のとき' do                                                                                                      
      before do                                                                                                               
        @num = 1                                                                                                              
      end                                                                                                                     
                                                                                                                              
      it { expect(@num % 2).to eq 1 }                                                                                         
    end                                                                                                                       
                                                                                                                              
    context '2のとき' do                                                                                                      
      before do                                                                                                               
        @num = 2                                                                                                              
      end                                                                                                                     
                                                                                                                              
      it { expect(@num % 2).to eq 0 }                                                                                         
    end                                                                                                                       
  end                                                                                                                         
end  
```

```
$ bundle exec rspec --format documentation

Sample
  2で割ったあまりは、変数Numが
    1のとき
      should eq 1
    2のとき
      should eq 0

Finished in 0.00128 seconds (files took 0.05667 seconds to load)
2 examples, 0 failures
```
構造化されて読みやすい！！

---

次: [ユーザの新規作成・編集ページの作成](./section02.md)
