# MathLibrarySolution

## 安裝說明
1. 使用Visual Studio 2019或更高版本開啟解決方案檔案
2. 在解決方案資源管理器中右鍵點擊解決方案，選擇「還原NuGet套件」(如適用)
3. 建置解決方案

## 執行說明
1. 確保已將MathLibraryTest設為啟動專案
   - 右鍵點擊MathLibraryTest專案，選擇「設為啟動專案」
2. 按F5執行程式
3. 查看命令列輸出結果
4. 錯誤日誌會生成在執行目錄下的log.txt檔案中

## 專案結構
- MathLibrary: 數學運算類別庫，封裝為DLL
- MathLibraryTest: 主控台應用程式，用於測試MathLibrary

## 功能
- Add: 兩數相加
- Subtract: 兩數相減
- Divide: 除法運算，處理除以零的情況
