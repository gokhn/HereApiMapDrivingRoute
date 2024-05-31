# HERE Map with Route Example

Bu proje, HERE Maps API kullanarak bir harita üzerinde rota çizen bir örneği içerir. Aşağıda, proje hakkında detaylı bilgileri ve kullanım örneklerini bulabilirsiniz.

## Başlarken

Bu projeyi kullanmak için öncelikle HERE Maps API anahtarınızı almanız gerekmektedir. Anahtarınızı aldıktan sonra aşağıdaki adımları izleyerek projeyi çalıştırabilirsiniz.

### Gereksinimler

- Web tarayıcısı (Chrome, Firefox, Safari, vb.)
- HERE Maps API anahtarı

### Kurulum

1. Bu projeyi bilgisayarınıza klonlayın:
    ```sh
    git clone https://github.com/kullaniciadi/proje-adi.git
    ```

2. Proje dizinine gidin:
    ```sh
    cd proje-adi
    ```

3. `index.html` dosyasını açın ve HERE Maps API anahtarınızı ekleyin.

### Kullanım

Aşağıda, projede kullanılan önemli fonksiyonlar ve kod parçacıkları bulunmaktadır:

#### Haritayı Başlatma

```javascript
var platform = new H.service.Platform({
    apikey: 'YOUR_API_KEY_HERE'
});

var defaultLayers = platform.createDefaultLayers();

var map = new H.Map(
    document.getElementById('mapContainer'),
    defaultLayers.vector.normal.map,
    {
        zoom: 7,
        center: { lat: 40.5, lng: 29.0 }
    }
);

var mapEvents = new H.mapevents.MapEvents(map);
var behavior = new H.mapevents.Behavior(mapEvents);
var ui = H.ui.UI.createDefault(map, defaultLayers);
```
### Ornek 

![Örnek Harita](https://github.com/gokhn/HereApiMapDrivingRoute/blob/main/HereMapProject/route.png)
