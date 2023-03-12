Marisa
Multi Advanced Replay files Import and Sort Application
Copyright © 2023- Mashiro Tamane

#これは何?
Replayファイルをゲームのreplayフォルダに手軽に仕分けしてくれるツールです。
正式名称はMulti Advanced Replay files Import and Sort Applicationですが長いので頭文字をとって略称は"Marisa"です。
名前に関して特に他意はありません。

#お問い合わせ
フィードバックはGitHubリポジトリにissueを建てていただくとありがたいです。
https://github.com/armadillo-winX/marisa

GitHubをお使いでない場合もしくはそのほかのお問い合わせは開発者TwitterもしくはMisskeyへご連絡ください。
開発者Twitter
https://twitter.com/PhotonSak
開発者Misskey
https://misskey.io/@mashironn

#よくあるとされる質問
Q.どうしてGUIじゃないんですか?
A.マルチスレッドで仕分け処理を実装しようと思ったときに、別スレッドからメインウィンドウのコントロールのプロパティにアクセスする方法がよくわからなかったからです。
もう少し時間があれば何とかなったと思うんですがなにぶん時間がなかったので許してください。

Q.略称から名前考えましたよね?
A.たまたまです。

Q.CUIアレルギーなのでGUIを実装して欲しいです。
A.ご要望があればGUIクライアントみたいなのを作ってみます。

Q.東方管制塔にも実装すれば良いじゃん。
A.Glasgow(ver2.x.x.x)に実装しようと思ってます。

Q.ソースコードとかってありますか?
A.#お問い合わせの項にGitHubリポジトリへのリンクを貼ってあります。

Q.動かないです。
A.Marisaの動作には .NET Runtime 7.0 が必要ですので下のリンクからインストールしてみてください。
https://dotnet.microsoft.com/ja-jp/download/dotnet/7.0
それでも動かない場合、GitHubのソースコードにissueを建てるか開発者TwitterもしくはMisskeyへご連絡ください。

Q.東方では誰が好きですか?
A.十六夜咲夜(特に妖々夢)

Q.Is English supported?
A.Not now but I think that I want to support English or other languages in the future.

Q.「パス設定の構成に失敗しました。」というエラーメッセージが出ました。
A.以下のケースが考えられます。
・settingsフォルダかsettingsフォルダ内のPathConfig.xmlのアクセス権が管理者権限もしくはそれ以上の権限に設定されている。
・settingsフォルダかsettingsフォルダ内のPathConfig.xmlが別のソフトウェアによって使用されていてMarisaがアクセスできない。
・PathConfig.xmlが不正なxmlファイルである。

Q.「replayディレクトリの生成に失敗しました。」というエラーメッセージが出ました。
A.以下のケースが考えられます。
・marisa.exeが存在するフォルダのアクセス権が管理者権限もしくはそれ以上の権限に設定されている。

Q.エラーとか怖いし権限とかよくわかんない！
A.開発者TwitterもしくはMisskeyへ気軽にご連絡ください。

#更新履歴
v1.1.0
軽微な修正。
ReadMe.txtに更新履歴追加。

v1.0.0
初版