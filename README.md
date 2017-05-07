# fbx sdk c# wrapper


---

FbxWrapper��fbx sdk��c#��װ��Ŀ����Ϊ�˷���fbx���ߵĿ�����ͬʱҲ���Է������Unity���ɡ�����ʹ��[SWIG][1]���ɡ�Ŀǰʹ��[fbx 2016 vs2013�汾][2]����Ҫ���������µ�fbx sdk�汾Ӧ�ò�����ѡ�
### ʵ��

 - ����Ҫ����ȷ��˳��include���е�ͷ�ļ���Ϊ��ʵ����һ��С����**IncludeGraph**�����ڶ����е�ͷ�ļ�����������ϵ��������ȥ��ѭ��������
 - ������Ҫ����ƽ̨��صĺ궨��
```cplusplus
#define _WIN32
#define _WIN64
#define _MSC_VER 1800
#define _M_X64
```
 - ����ͷ�ļ���ҪС���޸ġ�swig��parser����֧��ĳЩc++�﷨������
```cplusplus
typedef const double(kDouble44)[4][4] ;
```
```cplusplus
const static int sTypeTextureStartIndex = int(eTextureDiffuse);
```
 - swig�����Զ�ʵ����ģ�壬һЩ�ؼ���ģ������Ҫ�ֶ�ʵ������������Щģ����ᱻ���ԡ���Ҫע����ǣ��ֶ�ʵ������λ�������ƣ���Ҫ��ģ���ඨ��֮�󣬱�ʹ��֮ǰ������
 ```
%template(FbxDouble2) FbxVectorTemplate2<FbxDouble>;
%template(FbxDouble3) FbxVectorTemplate3<FbxDouble>;
%template(FbxDouble4) FbxVectorTemplate4<FbxDouble>;
%template(FbxDouble4x4) FbxVectorTemplate4<FbxDouble4>;
%template(FbxLayerElementTemplateFbxInt)FbxLayerElementTemplate<int>;
%template(FbxLayerElementTemplateFbxDouble)FbxLayerElementTemplate<double>;
 ```
 Ŀǰֻʵ�����˲��ֳ��õ�ģ�壬������Ҫ���Է���ļ����µ�ģ��ʵ����

 - fbx sdk�ĺܶ�ӿ���Ҫ�Ȼ�û���ָ�룬Ȼ����down cast������
    ```cplusplus
    FbxAnimStack* pAnimStack = FbxCast<FbxAnimStack>(pScene->GetSrcObject(FBX_TYPE(FbxAnimStack), n)
    ```
    Ĭ�ϵ������c#�����в��ܴ����������������ʹ����չ���������������ķ���ʵ��down cast������
    ```
    %extend FbxAnimStack {
      static FbxAnimStack *Cast(FbxObject *base) {
        return FbxCast<FbxAnimStack>(base);
      }
};
    ```
    c#�п�������
    ```csharp
    FbxObject obj = scene.GetSrcObject(FbxAnimStack.ClassId, 0);
    FbxAnimStack stack = FbxAnimStack.Cast(obj);
    ```
    ͬ����Ŀǰֻʵ�����������õ����͡���Ҫ�Ǻ����׼����µ�����ת����
 - ��rename������������أ�����
```cplusplus
 %rename(add)             operator+;
 %rename(pos)             operator+();
 %rename(sub)             operator-;
 %rename(neg)             operator-();
```
 - ��һЩ������lib�в����ڣ��ᵼ�����Ӳ�����ԭ��δ֪��ֻ�ú��Ե���Щ���š�����һЩ���ɵĴ����л���  ��protect��Ա��Ҳһ�����Ե�
```
%ignore FbxSelectionToTimeFormat;
%ignore FbxSelectionToTimeMode;
%ignore FbxTimeToSelection;
%ignore PropertyNotify;
%ignore FbxLayeredTexture::mInputData;
%ignore FbxImporter::SetPassword;
%ignore FbxSubDiv::SetLevelCount;
%ignore FbxImplementation::sDefaultType;
```
 - ����ָ������������ڷ�������
```
%include "carrays.i"
%include "cpointer.i"

%array_class(double, DoubleArray);
%array_class(float, FloatArray);
%array_class(int, IntArray);
```

### ����˵��

 - **adapter** c#�ӿڷ�װ
 - **FbxWrapperDll** fbx c++�ӿ�
 - **IncludeGraph** ����������ϵ����ͷ�ļ��Ĺ���
 - **header** �޸ĺ��fbx sdkͷ�ļ�
 - **test** sample����
 - **fbxwapper.i** swig�ӿ�����
 - **generate.cmd** ����swig��������

  [1]: http://swig.org/
  [2]: http://usa.autodesk.com/adsk/servlet/pc/item?siteID=123112&id=24314456