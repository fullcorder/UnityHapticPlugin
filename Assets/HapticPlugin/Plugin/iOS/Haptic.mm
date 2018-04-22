#import "Haptic.h"

#ifdef __cplusplus
extern "C" {
#endif

void selection()
{
    UISelectionFeedbackGenerator *generator = [[UISelectionFeedbackGenerator alloc] init];
    [generator prepare];
    [generator selectionChanged];
    generator = nil;
}

void impact(UIImpactFeedbackStyle style)
{
    UIImpactFeedbackGenerator *generator = [[UIImpactFeedbackGenerator alloc] initWithStyle:style];
    [generator prepare];
    [generator impactOccurred];
    generator = nil;
}

void nortification(UINotificationFeedbackType type)
{
    UINotificationFeedbackGenerator *generator = [[UINotificationFeedbackGenerator alloc] init];
    [generator prepare];
    [generator notificationOccurred:type];
    generator = nil;
}

bool _Haptic_supported()
{
    return [[UIDevice currentDevice] systemVersion].floatValue >= 10.0;
}

void _Haptic_generate(FeedbackType type)
{
    switch (type)
    {
        case Selection:
            selection();
            break;
        case ImpactLight:
            impact(UIImpactFeedbackStyleLight);
            break;
        case ImpactMedium:
            impact(UIImpactFeedbackStyleMedium);
            break;
        case ImpactHeavy:
            impact(UIImpactFeedbackStyleHeavy);
            break;
        case NortificationSuccess:
            nortification(UINotificationFeedbackTypeSuccess);
            break;
        case NortificationWarning:
            nortification(UINotificationFeedbackTypeWarning);
            break;
        case NortificationError:
            nortification(UINotificationFeedbackTypeError);
            break;
        default:
            break;
    }
}


#ifdef __cplusplus
}
#endif

